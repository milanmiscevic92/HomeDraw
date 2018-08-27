using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Domain.Entities;
using DAL.Infrastructure;
using System.Data.Entity;

namespace WebUI.Infrastructure
{
    public class AppUserManager : UserManager<AppUser>
    {
        public AppUserManager(IUserStore<AppUser> store) : base(store) { }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            HomeDrawDbContext db = context.Get<HomeDrawDbContext>();

            
            AppUserManager manager = new AppUserManager(new UserStore<AppUser>(db));

            

            return manager;
        }
    }
}