﻿using eCommerceProject.Data;
using eCommerceProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace eCommerceProject.Services
{
    public class SellerService
    {
        private readonly eCommerceProjectContext _context;

        public SellerService(eCommerceProjectContext context)
        {
            _context = context;
        }


        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
