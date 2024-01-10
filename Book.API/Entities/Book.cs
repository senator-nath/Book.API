using System.ComponentModel.DataAnnotations;

namespace Book.API.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public Book(int id, string name, string title, string description)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;

        }
    }
}
