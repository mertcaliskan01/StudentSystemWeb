using System;
using System.Net.Http;

namespace StudentSystemWeb.Helper
{
    public class StudentAPI : IDisposable
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://studentsystemapi.herokuapp.com/");
            return client;
        }
        public void Dispose()
        {
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

    }
}
