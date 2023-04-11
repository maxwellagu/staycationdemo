using System.ComponentModel.DataAnnotations;

namespace StaycationDemo.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
