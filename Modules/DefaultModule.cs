using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyRazorPartial.Modules
{
    public class DefaultModule : Nancy.NancyModule
    {
        public DefaultModule()
        {
            Get["/"] = _ =>
            {
                return View["Index"];
            };
        }
    }
}