using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1
{

    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    [Route("api/[controller]/[Action]")]
    public class HomeTAController : Controller
    {

        [HttpGet]
        public async Task<List<UserModel>> GetCity(CancellationToken currentCancellationToken)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            var responseAsString = await response.Content.ReadAsStringAsync();
            var responseDeserialize = JsonConvert.DeserializeObject<List<UserModel>>(responseAsString);
            return responseDeserialize;


            //HttpClient client = new HttpClient();
            //using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/users"))
            //{
            //    try
            //    {
            //        using (var response = await client.SendAsync(request, currentCancellationToken))
            //        {
            //            var x = await response.Content.ReadAsStreamAsync();
            //            using (StreamReader reader = new StreamReader(x))
            //            using (JsonTextReader json = new JsonTextReader(reader))
            //            {
            //                return new JsonSerializer().Deserialize<List<UserModel>>(json);
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
            //return null;
        }


        //// GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
