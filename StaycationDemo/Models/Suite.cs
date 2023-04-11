using StaycationDemo.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace StaycationDemo.Models
{
	public class Suite //: BaseModel
	{
        [Key]
        public int HotelId { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public bool IsBooked { get; set; }
		public bool IsMostPicked { get; set; }
		public string ImageUrl { get; set; }
		public decimal Price { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; }
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }



    }
}
