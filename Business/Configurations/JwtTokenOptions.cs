using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configurations
{
    public class JwtTokenOptions
    {
        public string Issuer { get; set; } //api.education.com
        public string Audience { get; set; } //www.education.com
        public string Key { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}
