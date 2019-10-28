using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllowHtml.Models
{
    public class Model
    {
        [AllowHtml]
        public string htmlString { get; set; }
    }
}