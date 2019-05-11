using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class SOAPBasedWebService : ISOAPBasedWebService
{
    // returns a welcome message
    public string Welcome(string yourName)
    {
       
        return string.Format(
           "Welcome to WCF Web Services with SOAP and XML, {0}!",
           yourName);
    } // end method Welcome
    public int Add(int val1, int val2)
    {
        return val1 + val2;
    }

}
