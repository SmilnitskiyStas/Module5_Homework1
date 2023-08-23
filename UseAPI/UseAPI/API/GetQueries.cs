using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UseAPI.API
{
    internal class GetQueries
    {
        public async Task ListUsersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/users?page=2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                }
            }
        }

        public async Task SinglUserAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/users/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                }
            }
        }

        public async Task SinglUserNotFoundAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/users/23");

                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Not Found");
                }
            }
        }

        public async Task ListResourceAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/unknown");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                }
            }
        }

        public async Task SinglResourceAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/unknown/2");

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = await result.Content.ReadAsStringAsync();
                }
            }
        }

        public async Task SinglResourceNotFoundAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/unknown/23");

                if (result.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Not Found!");
                }
            }
        }

        public async Task DelayedResponseAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(@"https://reqres.in/api/users?delay=3");

                if (result.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine("Error 404");
                }
            }
        }
    }
}
