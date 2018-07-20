using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Menu
    {
		public String Id { get; set; }
		public String Name { get; set; }
		public virtual ICollection<MenuItem> MenuItems { get; set; }
	}
}
