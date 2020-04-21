using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;


namespace Exam.dat
{
   public class ApplocationUser : IdentityUser
    {
        public ApplocationUser()
        {
            Claims = new List<IdentityUserClaim<string>>();
            Login = new List<IdentityUserLogin<string>>();
            Token = new List<IdentityUserToken<string>>();
            Role = new List<IdentityUserRole<string>>();
        }
        public string Imgurl { get; set; }
        public string  Class { get; set; }
        public string Signature { get; set; }
        public  ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public  ICollection<IdentityUserLogin<string>> Login { get; set; }
        public  ICollection<IdentityUserToken<string>> Token { get; set; }
        public  ICollection<IdentityUserRole<string>> Role { get; set; }
       
    }
}
