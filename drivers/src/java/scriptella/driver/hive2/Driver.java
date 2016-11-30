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
package scriptella.driver.hive2;

import scriptella.jdbc.GenericDriver;
import scriptella.jdbc.JdbcConnection;
import scriptella.spi.ConnectionParameters;

import java.sql.SQLException;
import java.util.Properties;

/**
 * Scriptella Adapter for Hive database.
 * <p>For configuration details and examples see <a href="package-summary.html">overview page</a>.
 *
 * @author Mehmet YUCE
 * @version 1.0
 */
public class Driver extends GenericDriver {
    public static final String HIVE_DRIVER_NAME = "org.apache.hive.jdbc.HiveDriver";

    public Driver() {
        loadDrivers(HIVE_DRIVER_NAME);
    }

    @Override
    protected JdbcConnection connect(ConnectionParameters parameters, Properties props) throws SQLException {
        return new HiveConnection(getConnection(parameters.getUrl(), props), parameters);
    }

}
