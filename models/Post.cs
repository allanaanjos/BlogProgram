using Dapper.Contrib.Extensions;

namespace Blog.models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Slug { get; set; } 
        public int CategoryId { get; set; }
    }   
}