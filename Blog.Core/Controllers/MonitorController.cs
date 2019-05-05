﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Common.Helper;
using Blog.Core.Common.LogHelper;
using Blog.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    //[Authorize(PermissionNames.Permission)]
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class MonitorController : Controller
    {


        // GET: api/Logs
        [HttpGet]
        public async Task<MessageModel<List<LogInfo>>> Get()
        {
          

            return new MessageModel<List<LogInfo>>()
            {
                msg = "获取成功",
                success = true,
                response = null
            };
        }

        // GET: api/Logs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Logs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Logs/5
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
