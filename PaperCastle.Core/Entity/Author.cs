﻿using System;
using System.Collections.Generic;

namespace PaperCastle.Core.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PictureURL { get; set; }
        public string Bio { get; set; }
        public int? CountryId { get; set; }  
        public Country? Country { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
