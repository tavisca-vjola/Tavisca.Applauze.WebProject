using System;

namespace Tavisca.Applauze.Core.WebProject.Models.Models
{
    public class Activity
    {
        public SourceType  SourceType{ get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}