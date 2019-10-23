using System;

namespace Tavisca.Applauze.WebProject.Models.Models
{
    public class Activity
    {
        public SourceType  SourceType{ get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}