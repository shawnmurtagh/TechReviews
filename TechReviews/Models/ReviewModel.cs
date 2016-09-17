 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReviews.Models
{
    public class Review
    {
        /* Properties to get the Title, Content, Author, Email, and select a foreign key: Category */
        [Key]
        public int ID { get; set; }

        [Required, StringLength(25), DataType(DataType.Text)]
        public string Title { get; set; }

        [Required, StringLength(300), DataType(DataType.Text)]
        public string Content { get; set; }

        [Required, StringLength(25), DataType(DataType.Text)]
        public string Author { get; set; }

        [DataType(DataType.EmailAddress)] /*Must be valid email*/
        public string Email { get; set; }

        private DateTime _PublishDate = DateTime.Now;
        public DateTime PublishDate { get { return _PublishDate; } set { _PublishDate = value; } }

        /*Refers to a dropdown list of instantiated Categories*/
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        virtual public Category Category { get; set; }

    }
    
}