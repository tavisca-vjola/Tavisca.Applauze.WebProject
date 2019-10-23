using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applauze.WebProject.Models.Models
{
    public class RewardedUser
    {
        public Rewards Rewards { get; set; }
        public User User { get; set; }
        public string Description { get; set; } 
        public DateTime Time{ get; set; }
     
    }
}
