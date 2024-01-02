﻿namespace DevDrive.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public bool IsVisible { get; set; }
    }

}
