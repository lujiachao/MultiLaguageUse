﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MultiLaguageLibrary;

namespace MultiLanguageWebTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public GetResourcesValue _getResourcesValue = MultiLanguageConfigurationProvider.ServiceProvider.GetRequiredService<GetResourcesValue>();
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _getResourcesValue.GetStringValue("001");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return _getResourcesValue.GetStringValue(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
