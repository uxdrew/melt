using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Melt.YodleeObjects
{
    public class CobrandLoginResponse
    {
        public string cobrandId { get; set; }
        public string applicationId { get; set; }
        public string locale { get; set; }
        public CobSession session { get; set; }
    }

    public struct CobSession
    {
        public string cobSession { get; set; }
    }
}
