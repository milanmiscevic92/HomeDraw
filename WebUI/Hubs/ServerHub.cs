using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WebUI.Models;
using Domain.Entities;
using DAL.Abstract;
using Domain.Entities.Bathroom;

namespace WebUI.Hubs
{
    public class ServerHub : Hub
    {
        private IUnitOfWork iUnitOfWork;

        public ServerHub(IUnitOfWork iUoW)
        {
            iUnitOfWork = iUoW;
        }

        public void Send(string name, string message)
        {

            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }


        public void CreateProject(string projectName, string projectDescription, string projectPassword, string userId)
        {

            Project project = new Project();

            project.ProjectName = projectName;
            project.ProjectDescription = projectDescription;
            project.ProjectOwnerId = userId;

            iUnitOfWork.ProjectRepository.Insert(project);
            iUnitOfWork.Save();

            int projectId = project.ProjectID;

            Clients.All.CreateProjectCallback(projectName, projectDescription, projectId);
        }

        // ============================DRAW OBJECTS========================================


        // ---------Bath---------------
        public void UpdateBath(Bath clientBath, int bathId)
        {
            

            Clients.AllExcept(Context.ConnectionId).updateBath(clientBath, bathId);
        }



        public void CreateBath(int projectId)
        {
            Bath bath = new Bath();
            bath.BathSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Baths != null)
            {
                project.Baths.Add(bath);
            }

            else
            {
                project.Baths = new List<Bath>();
                project.Baths.Add(bath);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            bath.ProjectId = project.ProjectID;

            iUnitOfWork.BathRepository.Insert(bath);

            iUnitOfWork.Save();

            int bid = bath.BathId;

            Clients.All.createBathCallback(bath.BathSize, bid);
        }


        //----------Lavatory-------------------
        public void UpdateLavatory(Lavatory clientLavatory, int lavatoryId)
        {
            Clients.AllExcept(Context.ConnectionId).updateLavatory(clientLavatory, lavatoryId);
        }

        public void CreateLavatory(int projectId)
        {
            Lavatory lavatory = new Lavatory();
            lavatory.LavatorySize = 140;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Lavatories != null)
            {
                project.Lavatories.Add(lavatory);
            }

            else
            {
                project.Lavatories = new List<Lavatory>();
                project.Lavatories.Add(lavatory);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            lavatory.ProjectId = project.ProjectID;

            iUnitOfWork.LavatoryRepository.Insert(lavatory);

            iUnitOfWork.Save();

            int lavatoryId = lavatory.LavatoryId;

            Clients.All.createLavatoryCallback(lavatory.LavatorySize, lavatoryId);

        }

    }
}