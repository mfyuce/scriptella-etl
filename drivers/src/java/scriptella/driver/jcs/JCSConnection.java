/*
 * Copyright 2006-2012 The Scriptella Project Team.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package scriptella.driver.jcs;

import net.sf.jni4net.Bridge;
import scriptcs.embedded.ExecutionManager;
import scriptella.driver.script.MissingQueryNextCallDetector;
import scriptella.driver.script.ParametersCallbackMap;
import scriptella.spi.*;
import scriptella.util.IOUtils;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;

/**
 * Scriptella connection adapter for JEXL.
 * <p>For configuration details and examples see <a href="package-summary.html">overview page</a>.
 *
 * @author Fyodor Kupolov
 * @version 1.0
 */
public class JCSConnection extends AbstractConnection {

    private static boolean _inited = false;
    private static Object _lockObject = new Object();
    //private Map<Resource, Script> cache = new IdentityHashMap<Resource, Script>();
    //Use the same factory method as in JexlExpression to share functions etc. 
    //private static final JexlEngine jexlEngine = JexlExpression.newJexlEngine();

    /**
     * Instantiates a new connection to JEXL.
     *
     * @param parameters connection parameters.
     */
    public JCSConnection(ConnectionParameters parameters) {
        super(Driver.DIALECT, parameters);

        if(!_inited) {
            synchronized (_lockObject)
            {
                if(!_inited) {
                    String nativePath = (String) parameters.getStringProperty("nativepath");
                    System.out.println(nativePath);
                    if (nativePath != null) {
                        System.setProperty("java.library.path", System.getProperty("java.library.path") + nativePath);
                    }
                    // create bridge, with default setup
                    // it will lookup jni4net.n.dll next to jni4net.j.jar
                    Bridge.setVerbose(true);
                    Bridge.setDebug(true);

                    try {
                        Bridge.init();
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                    String rootFolder = null;
                    try {
                        rootFolder = ExecutionManager.class.getProtectionDomain().getCodeSource().getLocation().toURI().getPath();
                        File file = new File(rootFolder);
                        File parentDir = file.getParentFile(); // to get the parent dir
                        rootFolder = file.getParent(); // to get the parent dir name
                    } catch (URISyntaxException e) {
                        e.printStackTrace();
                    }
                    System.out.println(rootFolder);

                    try {
                        Bridge.LoadAndRegisterAssemblyFrom(new java.io.File(rootFolder + "/ScriptCs.Embedded.j4n.dll"));
                        Bridge.LoadAndRegisterAssemblyFrom(new java.io.File(rootFolder + "/ScriptCs.Embedded.dll"));
                    } catch (Exception e) {
                        e.printStackTrace();
                    }
                    // here you go!
                    //Console.WriteLine("Hello .NET world!\n");
                    //System.loadLibrary("ScriptCs.Embedded");

                    ExecutionManager.InitRuntime();
                    _inited=true;
                }
            }
        }
    }

    public void executeScript(Resource scriptContent, ParametersCallback parametersCallback) throws ProviderException {
        run(scriptContent, new JCSContextMap(new ParametersCallbackMap(parametersCallback)));
    }

    public void executeQuery(Resource queryContent, ParametersCallback parametersCallback, QueryCallback queryCallback) throws ProviderException {
        final ParametersCallbackMap parametersMap = new ParametersCallbackMap(parametersCallback, queryCallback);
        MissingQueryNextCallDetector detector = new MissingQueryNextCallDetector(parametersMap, queryContent);
        run(queryContent, new JCSContextMap(parametersMap));
        detector.detectMissingQueryNextCall();
    }



    private void run(Resource resource, JCSContextMap ctx) {
        //Script script = cache.get(resource);
        //if (script == null) {
            String s;
            try {
                s = IOUtils.toString(resource.open());
            } catch (IOException e) {
                throw new JCSProviderException("Unable to open resource", e);
            }
            //try {
            //    cache.put(resource, script = jexlEngine.createScript(s));
           // } catch (Exception e) {
            //    throw new JCSProviderException("Failed to compile csscript script", e);
            //}
        //}
        try {
            ExecutionManager.ExecuteText( s);//ctx);
        } catch (Exception e) {
            throw new JCSProviderException("Failed to execute csscript", e);
        }
    }

    /**
     * Closes the connection and releases all related resources.
     */
    public void close() throws ProviderException {
        //cache = null;
    }

}
