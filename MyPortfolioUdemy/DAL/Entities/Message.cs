﻿namespace MyPortfolioUdemy.DAL.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string NameSurname   { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public string SendDate { get; set; }
        public string IsRead { get; set; }
 

    }
}
