using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;
using KassaAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using KassaAPI.Models;
using Newtonsoft.Json.Linq;

namespace KassaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // Login data
        readonly string db = "ErrasmusHB";
        readonly string user = "anthony.moortgat@student.ehb.be";
        readonly string psw = "kassa";

        // GET: api/Customer
        [HttpGet]
        public string Get()
        {
            // Login
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;
            int userid = rpcClientLogin.login(db, user, psw);


            // Search all customers in res.partner
            IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            object[] filter = new object[2];
            filter[0] = new object[3] { "customer", "=", "true" };
            filter[1] = new object[3] { "name", "=", "Anthony" };
            // Put returned value in an XmlRpcStruct array
            XmlRpcStruct[] result = null;
            
            result = rpcField.Searchread("ErrasmusHB", userid, "kassa", "res.partner", "search_read", filter);

            // Create list of returned custommers
            List<Dto.DtoCustomer> customers = new List<Dto.DtoCustomer>();

            string test = "";

            // Go through all results in the XmlRpcStruct array
            foreach (var res in result)
            {
                // Create for each custommer an object
                test += JsonConvert.SerializeObject(res) + " /n";
            }

            return test;
            // return JsonConvert.SerializeObject(result);

            //return userid.ToString();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            // Login
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;
            int userid = rpcClientLogin.login(db, user, psw);


            // Search all customers in res.partner
            IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            object[] filter = new object[2];
            filter[0] = new object[3] { "customer", "=", "true" };

            // result = rpcField.Searchread("ErrasmusHB", userid, "kassa", "res.partner", "search_read", filter);
            object[] fields = new object[1] { "name"};
            int[] ids = new int[] { id };

            // Put returned value in an XmlRpcStruct array
            object[] result = rpcField.read(db, userid, psw, "res.partner", "read", ids, fields);

            return JsonConvert.SerializeObject(result);

            //return userid.ToString();
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
