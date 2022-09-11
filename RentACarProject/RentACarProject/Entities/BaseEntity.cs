﻿using System;

namespace RentACarProject.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
