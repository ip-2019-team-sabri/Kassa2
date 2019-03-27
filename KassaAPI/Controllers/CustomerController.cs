using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;
using KassaAPI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace KassaAPI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;

            //login
            int userid = rpcClientLogin.login("ErrasmusHB", "anthony.moortgat@student.ehb.be", "Kassa");

            //Add Contacts(Customers)
            IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            XmlRpcStruct addPairFields = new XmlRpcStruct();
            addPairFields.Add("name", "new_test_Customer1");
            int resAdd = rpcField.create("Db_name", userid, "Db_Password", "res.partner", "create", addPairFields);



            //create new model(table) and return model_id
            //IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            XmlRpcStruct addModelparam = new XmlRpcStruct();
            addModelparam.Add("name", "Custom_Model");
            addModelparam.Add("model", "x_customModel_name");
            addModelparam.Add("state", "manual");
            int model_id = rpcField.create("Db_name", userid, "Db_Password", "ir.model", "create", addModelparam);


            //find existing model(table) by name and add field to it
            object[] filter = new object[1];
            filter[0] = new object[3] { "model", "=", "res.partner" };
            int[] model = rpcField.search("Db_name", userid, "Db_Password", "ir.model", "search", filter);

            //create new field(column) to particular model by id and return field_id
            //XmlRpcStruct addPairFields = new XmlRpcStruct();
            addPairFields.Add("model_id", model[0]);//12 for ir.ui.menu
            addPairFields.Add("name", "x_CustomField_name");
            addPairFields.Add("field_description", "Field_label");
            addPairFields.Add("ttype", "char");
            addPairFields.Add("state", "manual");//base
            addPairFields.Add("required", true);
            int resAdd1 = rpcField.create("Db_name", userid, "Db_Password", "ir.model.fields", "create", addPairFields);

            return View();
        }
    }
}