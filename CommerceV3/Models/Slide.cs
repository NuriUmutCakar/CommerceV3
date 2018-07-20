using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Slide
    {
		public String Id { get; set; }
		public String Name { get; set; }
		public String Image { get; set; }
		public String Url { get; set; }
		public String Target { get; set; }
		public bool IsPublished { get; set; }
		public int Position { get; set; }
	}
}
