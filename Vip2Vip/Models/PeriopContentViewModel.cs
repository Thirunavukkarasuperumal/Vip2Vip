using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vip2Vip.Models
{
    public class PeriopContentViewModel
    {
        public int CourseID { get; set; }
        public string Description { get; set; }
        public string TemplateID { get; set; }
        public string CourseType { get; set; }
        public bool IsActive { get; set; }
    }
}