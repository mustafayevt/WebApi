using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {
        List<TestEntity> list;

        public TestController()
        {
            list = new List<TestEntity>();
            list.Add(new TestEntity() { Id = 1, Name = "Test1" });
        }

        public string Get(string json)
        {
            TestModel model = JsonConvert.DeserializeObject<TestModel>(json);
            TestEntity ent =  list.FirstOrDefault(x=> x.Id == model.Id);
            return JsonConvert.SerializeObject(ent);

        }

    }
}
