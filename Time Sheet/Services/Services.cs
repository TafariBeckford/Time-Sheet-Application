using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Sheet.Models;

namespace Time_Sheet.Services
{
    public class Services
    {
        public static List<Client> GetClient()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Clients.ToList();
            }
        }
        //public static List<Manager> GetManager()
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        return context.Clients.
        //    }
        }
}