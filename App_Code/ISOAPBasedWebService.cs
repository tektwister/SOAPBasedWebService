﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ISOAPBasedWebService
{


	// TODO: Add your service operations here
    // returns a welcome message
    [OperationContract]
    string Welcome(string yourName);

    [OperationContract]
    int Add(int val1, int val2);

}

