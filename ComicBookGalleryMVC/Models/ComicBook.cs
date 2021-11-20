﻿using System;
namespace ComicBookGalleryMVC.Models
{
    public class ComicBook
    {

        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }

        
    }
}