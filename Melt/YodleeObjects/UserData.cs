using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Melt.YodleeObjects
{
    public class UserData
    {
        public string id { get; set; }
        public string loginName { get; set; }
        public Name name { get; set; }
        public string roleType { get; set; }
        public UserSession session { get; set; }
        public Preferences preferences { get; set; }
    }

    public struct Preferences
    {
        public string currency { get; set; }
        public string timeZone { get; set; }
        public string dateFormat { get; set; }
        public string locale { get; set; }
    }

    public struct Name
    {
        public string first { get; set; }
        public string last { get; set; }
    }

    public struct UserSession
    {
        public string userSession { get; set; }
    }
}
