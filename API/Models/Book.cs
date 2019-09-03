﻿using System;
using System.Collections.Generic;

namespace GoodreadsCloneAPI.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public decimal AverageRating { get; set; }
        public string Isbn { get; set; }
        public short? NumPages { get; set; }
        public int RatingsCount { get; set; }
        public int TextReviewsCount { get; set; }
    }
}