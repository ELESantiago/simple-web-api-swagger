using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTemplate
{
    public class Example
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }

    }


    public static class Examples
    {
        public static IEnumerable<Example> ExampleList = new Example[]
        {
            new Example { Id = 1, Name = "First Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 2, Name = "Second Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 3, Name = "Third Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 4, Name = "Fourth Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 5, Name = "Fifth Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 6, Name = "Sixth Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 7, Name = "Seventh Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 8, Name = "Eighth Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 9, Name = "Nineth Example", CreationTime = DateTime.Now, IsDeleted = false },
            new Example { Id = 10, Name = "Tenth Example", CreationTime = DateTime.Now, IsDeleted = false },
        };
    }
}
