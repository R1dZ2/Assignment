using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7___Extension_Methods
{
    public class Interview
    {
        public int Age { get; set; }
        public string JobProfile { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string PortfolioUrl { get; set; }
        public string Suggestion { get; set;}

        public Interview()
        {

        }

        public Interview(string name, string jobProfile, string portfolioUrl, string suggestion, int age, long phoneNumber)
        {
            Name = name.CapitalizeLetter();
            JobProfile = jobProfile;
            PortfolioUrl = portfolioUrl.UrlEncode();
            Suggestion = suggestion;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
