using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applauze.WebProject.Models.Models
{
    public class Rules
    {
        public IEnumerable<string> GitHubRules { get; set; }
        public IEnumerable<string> TimeSheetRules { get; set; }
        public IEnumerable<string> BadgesRules { get; set; }
    }
}
