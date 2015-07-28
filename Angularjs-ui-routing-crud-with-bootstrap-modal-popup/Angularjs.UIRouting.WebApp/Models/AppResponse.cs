using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angularjs.UIRouting.WebApp.Models
{
    public class AppResponse
    {
        public bool Status { get; set; }
        public String Message { get; set; }
        public Object Data { get; set; }
    }
}