using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applauze.Core.WebProject.Models.Models
{
    public class UserProfile
    {
        public User User{ get; set; }
        public IEnumerable<Activity> Timeline{ get; set; }
      

    }
}
