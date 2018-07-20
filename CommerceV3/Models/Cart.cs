using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Cart
    {
		public Cart()
		{
			IsActive = true;
		}
		public String Id { get; set; }
		public String Owner { get; set; }
		public virtual ICollection<CartItem> CardItems { get; set; }

		public String CreatedBy { get; set; }
		public DateTime CreateDate { get; set; }
		public String UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }

		public bool IsActive { get; set; }
	}
}
