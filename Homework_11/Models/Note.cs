using System;
using System.Collections.Generic;

namespace Homework_11.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Tags { get; set; }

        public Note()
        {
            CreatedAt = DateTime.Now;
            Tags = new List<string>();
        }
    }
}
