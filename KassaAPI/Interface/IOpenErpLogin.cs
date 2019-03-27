﻿using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Interface
{
    [XmlRpcUrl("http://10.3.56.6:8069/xmlrpc/2/common")]
    public interface IOpenErpLogin : IXmlRpcProxy
    {
        [XmlRpcMethod("login")]
        int login(string dbName, string dbUser, string dbPwd);

    }
}
