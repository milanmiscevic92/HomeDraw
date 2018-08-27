using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using WebUI.Infrastructure;
using WebUI.Models;
using DAL.Concrete;
using DAL.Abstract;

namespace WebUI.Controllers
{
    [Authorize]
    public class MainDashboardController : Controller
    {
        private IUnitOfWork iUnitOfWork;

        public MainDashboardController(IUnitOfWork uow)
        {
            iUnitOfWork = uow;
        }
        

        public ActionResult Index()
        {
            MainDashboardViewModel vm = new MainDashboardViewModel();


            vm.MyProjects = iUnitOfWork.ProjectRepository.Get().Where(p => p.ProjectOwnerId == User.Identity.GetUserId());

            return View(vm);
        }


    }
}