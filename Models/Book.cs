﻿namespace backend.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
        public required string Author { get; set; }
        public required string Description { get; set; }
    }
}
