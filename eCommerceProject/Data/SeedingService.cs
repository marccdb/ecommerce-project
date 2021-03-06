﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceProject.Models;
using eCommerceProject.Models.Enums;

namespace eCommerceProject.Data
{
    public class SeedingService
    {
        private eCommerceProjectContext _context;

        public SeedingService(eCommerceProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
               _context.Seller.Any() || 
               _context.SalesRecord.Any())
            {
                return; //Database already populated
            }

            Department d1 = new Department("Electronics");
            Department d2 = new Department("Books");
            Department d3 = new Department("Appliances");
            Department d4 = new Department("Home");

            Seller s1 = new Seller("Marcio", "marcio@email", new DateTime(1985 - 09 - 05), 10000, d1);
            Seller s2 = new Seller("João", "joao@email", new DateTime(1986 - 04 - 10), 10000, d4);
            Seller s3 = new Seller("Maria", "maria@email", new DateTime(1983 - 11 - 21), 10000, d2);

            SalesRecord r1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SalesStatus.BILLED, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2018, 09, 4), 7000.0, SalesStatus.BILLED, s3);
            SalesRecord r3 = new SalesRecord(new DateTime(2018, 09, 13), 4000.0, SalesStatus.CANCELED, s2);
            SalesRecord r4 = new SalesRecord(new DateTime(2018, 09, 1), 8000.0, SalesStatus.BILLED, s1);
            SalesRecord r5 = new SalesRecord(new DateTime(2018, 09, 21), 3000.0, SalesStatus.BILLED, s3);
            SalesRecord r6 = new SalesRecord(new DateTime(2018, 09, 15), 2000.0, SalesStatus.BILLED, s1);
            SalesRecord r7 = new SalesRecord(new DateTime(2018, 09, 28), 13000.0, SalesStatus.BILLED, s2);
            SalesRecord r8 = new SalesRecord(new DateTime(2018, 09, 11), 4000.0, SalesStatus.BILLED, s1);
            SalesRecord r9 = new SalesRecord(new DateTime(2018, 09, 14), 11000.0, SalesStatus.PENDING, s1);
            SalesRecord r10 = new SalesRecord(new DateTime(2018, 09, 7), 9000.0, SalesStatus.BILLED, s2);
            SalesRecord r11 = new SalesRecord(new DateTime(2018, 09, 13), 6000.0, SalesStatus.BILLED, s2);
            SalesRecord r12 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SalesStatus.PENDING, s3);
            SalesRecord r13 = new SalesRecord(new DateTime(2018, 09, 29), 10000.0, SalesStatus.BILLED, s3);
            SalesRecord r14 = new SalesRecord(new DateTime(2018, 09, 4), 3000.0, SalesStatus.BILLED, s2);
            SalesRecord r15 = new SalesRecord(new DateTime(2018, 09, 12), 4000.0, SalesStatus.BILLED, s1);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15);

            _context.SaveChanges();


        }
    }
}
