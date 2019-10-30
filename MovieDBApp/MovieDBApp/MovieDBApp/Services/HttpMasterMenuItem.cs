using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{

    public class HttpMasterMenuItem
    {
        public HttpMasterMenuItem()
        {
            TargetType = typeof(HttpMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}