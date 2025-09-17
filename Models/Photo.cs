﻿namespace PhotoAlbum.Models
{
    public class Photo
    {
        //Primary key
        public int PhotoId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Filename { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; }

        //Foreign key 
        public int CategoryId { get; set; }

        //Navigation property
        public Category Category { get; set; }

    }
}
