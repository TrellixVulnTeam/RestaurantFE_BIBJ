﻿using System.Text;

namespace Restaurant.Business.Configuration
{
    public class AuthOptions
    {
        public string Issuer { get; set; }

        public string Audience { get; set; }

        public string SecurityKey { get; set; }

        public byte[] SecurityKeyAsBytes => Encoding.UTF8.GetBytes(SecurityKey);

        public int TokenLifetimeSeconds { get; set; } = 60 * 60; // 1 hour
    }
}
