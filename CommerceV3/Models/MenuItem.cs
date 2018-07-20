using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class MenuItem
    {
		public String Id { get; set; }
		public String Name { get; set; }
		public String Url { get; set; }
		public String Target { get; set; }
		public bool IsPublished { get; set; }
		public int Position { get; set; }

		public string ParentMenuItemId { get; set; }
		[ForeignKey("ParentMenuItemId")]
		public MenuItem ParentMenuItem { get; set; }
		public virtual ICollection<MenuItem> ChildMenuItems { get; set; }

	}
}
