/**
 * $Header: $
 * $Revision: $
 * $Date: $
 *
 * Copyright 2003-2005
 * All rights reserved.
 */
package scriptella.driver.jcs;

import scriptella.spi.ProviderException;

/**
 * Thrown to indicate a problem with JEXL script.
 *
 * @author Fyodor Kupolov
 * @version 1.0
 */
public class JCSProviderException extends ProviderException {
    public JCSProviderException() {
    }

    public JCSProviderException(String message) {
        super(message);
    }

    public JCSProviderException(String message, Throwable cause) {
        super(message, cause);
    }

    public JCSProviderException(Throwable cause) {
        super(cause);
    }

    public String getProviderName() {
        return Driver.DIALECT.getName();
    }
}
