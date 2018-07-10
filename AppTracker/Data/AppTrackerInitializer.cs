﻿using AppTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppTracker.Data
{
    public class AppTrackerInitializer : DropCreateDatabaseIfModelChanges<AppTrackerContext>
    {
        protected override void Seed(AppTrackerContext context)
        {
            var companies = new List<Company>
            {
                new Company { ID = 1, Name = "ABC Company", ContactName = "Sue Smith", ContactTitle = "HR Manager", Email = "sue@abcco.com", Phone = "5025551212", Website = "www.abccompany.com" },
                new Company { ID = 2, Name = "Microsoft", ContactName = "Joe Johnson", ContactTitle = "Manager", Email = "joe@ms.com", Phone = "5025461234", Website = "www.microsoft.com" },
                new Company { ID = 3, Name = "IT Inc.", ContactName = "Bob Brown", ContactTitle = "IT Manager", Email = "bob@it.com", Phone = "5022221555", Website = "www.itinc.com" }
            };

            companies.ForEach(s => context.Companies.Add(s));
            context.SaveChanges();

            var applications = new List<Application>
            {
                new Application { ID = 1, AppliedVia = "LinkedIn", DateApplied=DateTime.Parse("12/12/2005"), Position = "software engineer"},

                new Application { ID = 2, AppliedVia = "Indeed", DateApplied=DateTime.Parse("12/05/2005"), Position = "DBA"},

                new Application { ID = 3, AppliedVia = "LinkedIn", DateApplied=DateTime.Parse("11/25/2005"), Position = "web developer"}
            };

            applications.ForEach(a => context.Applications.Add(a));
            context.SaveChanges();
        }
    } 
}