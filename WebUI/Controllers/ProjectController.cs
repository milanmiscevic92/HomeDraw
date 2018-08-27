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
using System.Data.Entity.Core.Objects;
using DAL.Concrete;
using DAL.Abstract;


namespace WebUI.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private IUnitOfWork iUnitOfWork;

        public ProjectController(IUnitOfWork uow)
        {
            iUnitOfWork = uow;
        }

        public ActionResult CreateOrJoinProject()
        {
            AppUser user = iUnitOfWork.UsersRepository.GetById(User.Identity.GetUserId());

            CreateOrJoinProjectViewModel vm = new CreateOrJoinProjectViewModel();

            vm.JoinedProjects = iUnitOfWork.ProjectRepository.Get().Where(p => p.Participants.Contains(user));

            vm.AvailableProjects = iUnitOfWork.ProjectRepository.Get().Except(vm.JoinedProjects);

            vm.UserId = User.Identity.GetUserId();

            return View("Rooms", vm);
        }

        public ActionResult JoinProject(int projectId)
        {
            Project thisProject = iUnitOfWork.ProjectRepository.GetById(projectId);
            AppUser thisUser = iUnitOfWork.UsersRepository.GetById(User.Identity.GetUserId());

            if(thisProject.Participants != null)
            {
                thisProject.Participants.Add(thisUser);
            }

            else
            {
                thisProject.Participants = new List<AppUser>();
                thisProject.Participants.Add(thisUser);
            }

            if(thisUser.ProjectsIParticipateIn != null)
            {
                thisUser.ProjectsIParticipateIn.Add(thisProject);
            }

            else
            {
                thisUser.ProjectsIParticipateIn = new List<Project>();
                thisUser.ProjectsIParticipateIn.Add(thisProject);
            }

            iUnitOfWork.ProjectRepository.Update(thisProject);
            iUnitOfWork.UsersRepository.Update(thisUser);
            iUnitOfWork.Save();


            return RedirectToAction("CreateOrJoinproject");
        }


        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(CreateProjectViewModel vm)
        {
            AppUser user = iUnitOfWork.UsersRepository.GetById(User.Identity.GetUserId());

            vm.Project.ProjectOwnerId = User.Identity.GetUserId();
            vm.Project.Participants = new List<AppUser>();
            vm.Project.Participants.Add(user);

            user.ProjectsIParticipateIn = new List<Project>();
            user.ProjectsIParticipateIn.Add(vm.Project);

            iUnitOfWork.UsersRepository.Update(user);
            iUnitOfWork.ProjectRepository.Insert(vm.Project);
            iUnitOfWork.Save();


            return RedirectToAction("Index", "MainDashboard");
        }

        public ViewResult OpenProject(int projectId)
        {
            OpenProjectViewModel vm = new OpenProjectViewModel();
            vm.Project = iUnitOfWork.ProjectRepository.GetById(projectId);
            return View(vm);
        }

        [HttpPost]
        public ActionResult DeleteProject(int projectId)
        {
            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);


            iUnitOfWork.ProjectRepository.Delete(projectId);
            iUnitOfWork.Save();

            return RedirectToAction("Index", "MainDashboard");
        }

        [HttpPost]
        public ActionResult SaveProject()
        {
            return null;
        }


    }
}