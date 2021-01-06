namespace BockernasHus.Models.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public string Publisher { get; set; }

        [Required]
        public int Price { get; set; }

        public Condition Condition { get; set; }

        public Type Type { get; set; }

        public DateTime PublishingYear { get; set; }

        public int NumberOfPages { get; set; }

        public int Description { get; set; }

        public string Image { get; set; }

    }
}