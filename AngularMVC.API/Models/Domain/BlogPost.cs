﻿namespace AngularMVC.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string ImagesUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public string Author2 { get; set; }
        public bool IsVisible { get; set; }
        public bool IsVisible2 { get; set; }
    }
}
