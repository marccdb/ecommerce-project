using eCommerceProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceProject.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus SalesStatus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int iD, DateTime date, double amount, SalesStatus salesStatus, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            SalesStatus = salesStatus;
            Seller = seller;
        }
    }
}
