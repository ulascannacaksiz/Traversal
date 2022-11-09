﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(y => y.ContactUsId == id).FirstOrDefault();
                values.Status = false;
                context.ContactUses.Update(values);
                context.SaveChanges();    
            }
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using(var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.Status == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.Status == true).ToList();
                return values;
            }
        }
    }
}
