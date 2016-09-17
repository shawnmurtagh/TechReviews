using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TechReviews.Models
{
    public class Category
    {
        /*properties of Category to be used in dropdown list for Review*/
        [Key]
        public int ID { get; set; }

        /*ICollection can be edited - IEnumerator cannot, List<> is heavier and has unneeded features*/
        virtual public ICollection<Review> Review { get; set; } 

        public string Name { get; set; }
        
    }
}