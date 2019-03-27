using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KassaAPI.Interface
{
    [XmlRpcUrl("http://10.3.56.6:8069/xmlrpc/2/object")]
    public interface IOpenErpAddFields : IXmlRpcProxy
    {
        [XmlRpcMethod("execute")]
        int create(String dbName, int userId, string dbPwd, string model, string method, XmlRpcStruct fieldValues);

        [XmlRpcMethod("execute")]
        object[] read(string dbName, int userId, string dbPwd, string model, string method, int[] ids, object[] fields);

        [XmlRpcMethod("execute")]
        int[] search(string dbName, int userId, string dbPwd, string model, string method, object[] filter);
    }
}
