﻿namespace TestTask.Models.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
