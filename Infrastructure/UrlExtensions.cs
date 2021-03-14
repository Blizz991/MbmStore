using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
                                request.QueryString.HasValue
                                ? $"{request.Path}{request.QueryString}"
                                    : request.Path.ToString();

        //Example of URL with path and querystring: https://music.youtube.com/watch?v=uVGQl7twfJE&list=RDAObUFfj_YV3g37aYJU0HicpA

        //Path = https://music.youtube.com/watch
        //Querystring = ?v=uVGQl7twfJE&list=RDAObUFfj_YV3g37aYJU0HicpA
        //Querystring consists of the parameters v and list
        //v=uVGQl7twfJE
        //list=RDAObUFfj_YV3g37aYJU0HicpA
        // & specifies start of new parameter in the querystring
    }
}
