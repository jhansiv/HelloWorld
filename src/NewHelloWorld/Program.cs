using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)


        {
            Console.WriteLine("    Hello World!!!        ");
            

            CallingHelloWorld().Wait();           
        }

        static async Task CallingHelloWorld()
        {

            using (var client = new HttpClient()) //WebClient  
            {

                client.BaseAddress = new Uri("http://localhost:50038/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/HW");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                   
                    Console.WriteLine("From API:  "+ result.ToString());
                    Console.ReadLine();

                }

            }
        }
    }
}
