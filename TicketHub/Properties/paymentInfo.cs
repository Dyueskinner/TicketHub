﻿using System.ComponentModel.DataAnnotations;

namespace TicketHub.Properties
{
    public class paymentInfo
    {
        public int ConcertId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string CreditCard { get; set; }

        [Required]
        public string Expiration { get; set; }

        [Required]
        public string SecurityCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
