﻿namespace bmarketo.Models.Entities
{
    public class ContactFormEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Company { get; set; }
        public string Comment { get; set; } = null!;

    }
}
