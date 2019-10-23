using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applauze.Core.WebProject.Models.Models
{
    public class User
    {
        public string  Name { get; set; }
        public string Employeeid { get; set; }

        public string Tribe { get; set; }
        public string Email { get; set; }

        public Rewards Reward { get; set; }

    }
}
