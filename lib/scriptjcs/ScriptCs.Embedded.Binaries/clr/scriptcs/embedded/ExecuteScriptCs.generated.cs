//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScriptCs.Embedded {
    
    
    #region Component Designer generated code 
    public partial class ExecuteScriptCs_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::ScriptCs.Embedded.@__ExecuteScriptCs.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::ScriptCs.Embedded.ExecuteScriptCs), typeof(global::ScriptCs.Embedded.ExecuteScriptCs_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::ScriptCs.Embedded.ExecuteScriptCs), typeof(global::ScriptCs.Embedded.ExecuteScriptCs_))]
    internal sealed partial class @__ExecuteScriptCs : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__ExecuteScriptCs(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::ScriptCs.Embedded.@__ExecuteScriptCs.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ExecuteScriptCs);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RunText", "RunText0", "(Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RunFile", "RunFile1", "(Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorExecuteScriptCs0", "__ctorExecuteScriptCs0", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsyst" +
                        "em/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RunText0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle script) {
            // (Ljava/lang/String;)Lsystem/Object;
            // (LSystem/String;)LScriptCs/Contracts/ScriptResult;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::ScriptCs.Embedded.ExecuteScriptCs @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::ScriptCs.Embedded.ExecuteScriptCs>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::ScriptCs.Contracts.ScriptResult>(@__env, @__real.RunText(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, script)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle RunFile1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle scriptPath) {
            // (Ljava/lang/String;)Lsystem/Object;
            // (LSystem/String;)LScriptCs/Contracts/ScriptResult;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::ScriptCs.Embedded.ExecuteScriptCs @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::ScriptCs.Embedded.ExecuteScriptCs>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::ScriptCs.Contracts.ScriptResult>(@__env, @__real.RunFile(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, scriptPath)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void @__ctorExecuteScriptCs0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle logger, global::net.sf.jni4net.utils.JniLocalHandle fileSystem, global::net.sf.jni4net.utils.JniLocalHandle packageAssemblyResolver, global::net.sf.jni4net.utils.JniLocalHandle packageInstaller, global::net.sf.jni4net.utils.JniLocalHandle scriptPackResolver, global::net.sf.jni4net.utils.JniLocalHandle scriptExecutor, global::net.sf.jni4net.utils.JniLocalHandle filePreprocessor) {
            // (Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;Lsystem/Object;)V
            // (LCommon/Logging/ILog;LScriptCs/Contracts/IFileSystem;LScriptCs/Contracts/IPackageAssemblyResolver;LScriptCs/Contracts/IPackageInstaller;LScriptCs/Contracts/IScriptPackResolver;LScriptCs/Contracts/IScriptExecutor;LScriptCs/Contracts/IFilePreProcessor;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::ScriptCs.Embedded.ExecuteScriptCs @__real = new global::ScriptCs.Embedded.ExecuteScriptCs(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::Common.Logging.ILog>(@__env, logger), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IFileSystem>(@__env, fileSystem), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IPackageAssemblyResolver>(@__env, packageAssemblyResolver), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IPackageInstaller>(@__env, packageInstaller), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IScriptPackResolver>(@__env, scriptPackResolver), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IScriptExecutor>(@__env, scriptExecutor), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::ScriptCs.Contracts.IFilePreProcessor>(@__env, filePreprocessor));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::ScriptCs.Embedded.@__ExecuteScriptCs(@__env);
            }
        }
    }
    #endregion
}
