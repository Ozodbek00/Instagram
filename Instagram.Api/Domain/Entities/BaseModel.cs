﻿namespace Instagram.Api.Domain.Entities
{
    public class BaseModel
    {
        public long Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
