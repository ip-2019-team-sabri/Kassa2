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
        // GET: api/Customer
        [HttpGet]
        public string Get()
        {
            //login
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;
            int userid = rpcClientLogin.login("ErrasmusHB", "anthony.moortgat@student.ehb.be", "kassa");

            //if (userid > 0)
            //{
            //   return "login succesful";
            //}
            //else
            //{
            //    return "fout";
            //}

            //search a customer
            IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            object[] filter = new object[1];
            filter[0] = new object[3] { "customer", "=", "true" };
            XmlRpcStruct[] customer = rpcField.Searchread("ErrasmusHB", userid, "kassa", "res.partner", "search_read", filter);

            //List<Customer> customers = new List<Customer>();

            //foreach (var res in customer)
            //{
            //   string test = JsonConvert.SerializeObject(res);
            //  JObject jo = JObject.Parse(test);

            // Customer tempCustomer = new Customer(jo["Name"].ToString(), jo["Email"].ToString(), jo["UUID"].ToString(),
            //    Int32.Parse(jo["x_timestamp"].ToString()), Int32.Parse(jo["x_version"].ToString()));
            //customers.Add(tempCustomer);
            //}

            //return JsonConvert.SerializeObject(customers);
            return "s";
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "s";

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
