using FirstWebAPIDemoCS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstWebAPIDemoCS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private static List<Test> testList;
        public TestController()
        {
            if (testList == null)
            {

                testList = new List<Test>();
                testList.Add(new Test { Name = "Anand", Value = 1 });
                testList.Add(new Test { Name = "Tushar", Value = 2 });
            }
        }
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<Test> Get()
        {
            return testList.ToList();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public Test Get(string id)
        {
            return testList.Where(t => t.Name.Contains(id)).First();
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post(Test newTest)
        {
            testList.Add(newTest);
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(string id, Test updatedTest)
        {
            Test temp = Get(id);

        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            testList.Remove(Get(id));
        }
    }
}
