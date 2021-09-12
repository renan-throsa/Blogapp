﻿using System;

namespace Blogapp.Domain.Entities.Entities
{
    public class Comment : BaseEntity
    {
        public Post Post { get; set; }
        public User User { get; set; }
        public string Body { get; set; }
        public DateTimeKind TimeStamp { get; set; }
    }
}