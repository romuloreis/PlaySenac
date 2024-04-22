﻿using PlaySenac.Models.Enums;

namespace PlaySenac.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
