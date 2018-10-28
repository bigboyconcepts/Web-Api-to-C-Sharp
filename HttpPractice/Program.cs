using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpPractice.Internet.Interfaces;
using HttpPractice.Internet;
using HttpPractice.Models;

namespace HttpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IHttpRequest httpRequest = new HttpRequestOperation();

            var companies = httpRequest.MakeHttpRequestFromInternet().Result;

            foreach (var company in companies)
            {
                Console.WriteLine($"ID: {company.id}");
                Console.WriteLine($"Type: {company.attributes.type}");
                Console.WriteLine($"Name: {company.attributes.name}");
                Console.WriteLine($"Created At: {company.attributes.created_at}");
                Console.WriteLine($"Links: {company.links.self}");
                Console.WriteLine("============================================");
            }

            Console.Read();
        }
    }
}
