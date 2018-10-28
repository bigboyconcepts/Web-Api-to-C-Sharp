using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpPractice.Models;

namespace HttpPractice.Internet.Interfaces
{
    public interface IHttpRequest
    {
         Task<List<CompanyData>> MakeHttpRequestFromInternet();
    }
}
