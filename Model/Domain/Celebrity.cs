﻿using System;

namespace CelebrityAPI.Model.Domain
{
    public class Celebrity
    {
        public Guid Id { get; set; }
        public string ImageURL { get; set; }
        public string FullName { get; set; } 
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Category Category { get; set; }
        public Profession Profession { get; set; }
        public SocialMedia SocialMedia { get; set; }

    }
}