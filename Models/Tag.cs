
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Blog.Models
{
    [Table("[Tag]")]
    public class Tag
    {
        // public Tag(string name, string slug)
        // {
        //     Name = name;
        //     Slug = slug;
        // }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        // public override string ToString()
        // {
        //     return "Name: " + Name + " Slug:" + Slug;
        // }
    }
}