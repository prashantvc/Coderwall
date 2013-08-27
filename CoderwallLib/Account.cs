using System.Collections.Generic;

namespace CoderwallLib
{
    public class Accounts
    {
        public string github { get; set; }
    }

    public class Badge
    {
        public string name { get; set; }
        public string description { get; set; }
        public string created { get; set; }
        public string badge { get; set; }
    }

    public class Profile
    {
        public string username { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int endorsements { get; set; }
        public string team { get; set; }
        public Accounts accounts { get; set; }
        public List<Badge> badges { get; set; }
    }
}