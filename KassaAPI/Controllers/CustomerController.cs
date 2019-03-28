using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horizon.XmlRpc.Client;
using Horizon.XmlRpc.Core;
using KassaAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;

            //login
            int userid = rpcClientLogin.login("ErrasmusHB", "anthony.moortgat@student.ehb.be", "kassa");

            if (userid > 0)
            {
                return "login succesful";
            }
            else
            {
                return "fout";
            }
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public object Get(int id)
        {
            //login
            IOpenErpLogin rpcClientLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            rpcClientLogin.NonStandard = XmlRpcNonStandard.AllowStringFaultCode;
            int userid = rpcClientLogin.login("ErrasmusHB", "anthony.moortgat@student.ehb.be", "kassa");

            //search a customer
            IOpenErpAddFields rpcField = XmlRpcProxyGen.Create<IOpenErpAddFields>();
            object[] filter = new object[1];
            filter[0] = new object[3] { "model", "=", "res.partner" };
            int[] model = rpcField.search("ErrasmusHB", userid, "kassa", "ir.model", "search", filter);
            return model;

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
