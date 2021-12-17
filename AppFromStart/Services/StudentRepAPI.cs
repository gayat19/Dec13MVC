using AppFromStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class StudentRepAPI : IRepo<Student>
    {
        HttpClient client;
        public StudentRepAPI()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:45524");
        }
        public bool Add(Student t)
        {
            t = new Student() { Id = 102, Name = "Tim" };
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/Student", t).Result;
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Student> GetAll()
        {
            HttpResponseMessage response = client.GetAsync("api/Student").Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<Student>>(data);
                return result;
            }
            return null;
        }

        public Student Update(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
