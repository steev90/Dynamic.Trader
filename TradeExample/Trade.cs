﻿using System;

namespace TradeExample
{
    public class Trade
    {
        public long Id { get; private set; }
        public string CurrencyPair { get; private set; }
        public string Customer { get; private set; }
        public decimal Price { get; set; }
        public TradeStatus Status { get; private set; }
        public DateTime Timestamp { get; private set; }


        public Trade(long id, string customer, string currencyPair, TradeStatus status, decimal price=0)
        {
            Id = id;
            Customer = customer;
            CurrencyPair = currencyPair;
            Status = status;
            Price = price;
            Timestamp = DateTime.Now;
        }
    }
}