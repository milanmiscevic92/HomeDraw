using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using WebUI.Models;
using Domain.Entities;
using DAL.Abstract;
using Domain.Entities.Bathroom;
using Domain.Entities.ConstructionElements;
using Domain.Entities.Kitchen;
using Domain.Entities.LivingRoom;

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




        //------------------ shower --------------------
        public void UpdateShower(Shower clientShower, int showerId)
        {
            Clients.AllExcept(Context.ConnectionId).updateShower(clientShower, showerId);
        }

        public void CreateShower(int projectId)
        {
            Shower shower = new Shower();
            shower.ShowerSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Showers != null)
            {
                project.Showers.Add(shower);
            }

            else
            {
                project.Showers = new List<Shower>();
                project.Showers.Add(shower);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            shower.ProjectId = project.ProjectID;

            iUnitOfWork.ShowerRepository.Insert(shower);

            iUnitOfWork.Save();

            int showerId = shower.ShowerId;

            Clients.All.createShowerCallback(shower.ShowerSize, showerId);

        }



        //------------------door-----------------------------
       
        public void UpdateDoor(Door clientDoor, int doorId)
        {
            Clients.AllExcept(Context.ConnectionId).updateDoor(clientDoor, doorId);
        }

        public void CreateDoor(int projectId)
        {
            Door door = new Door();
            door.DoorSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Doors != null)
            {
                project.Doors.Add(door);
            }

            else
            {
                project.Doors = new List<Door>();
                project.Doors.Add(door);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            door.ProjectId = project.ProjectID;

            iUnitOfWork.DoorRepository.Insert(door);

            iUnitOfWork.Save();

            int did = door.DoorId;

            Clients.All.createDoorCallback(door.DoorSize, did);
        }

        //------------------window-----------------------------
        public void UpdateWindow(Window clientWindow, int windowId)
        {
            Clients.AllExcept(Context.ConnectionId).updateWindow(clientWindow, windowId);
        }

        public void CreateWindow(int projectId)
        {
            Window window = new Window();
            window.WindowSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Windows != null)
            {
                project.Windows.Add(window);
            }

            else
            {
                project.Windows = new List<Window>();
                project.Windows.Add(window);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            window.ProjectId = project.ProjectID;

            iUnitOfWork.WindowRepository.Insert(window);

            iUnitOfWork.Save();

            int wid = window.WindowId;

            Clients.All.createWindowCallback(window.WindowSize, wid);
        }

        //-----------------refrigerator--------------------------------
       
        public void UpdateFridge(Refrigerator clientFridge, int fridgeId)
        {
            Clients.AllExcept(Context.ConnectionId).updateFridge(clientFridge, fridgeId);
        }

        public void CreateFridge(int projectId)
        {
            Refrigerator fridge = new Refrigerator();
            fridge.RefrigeratorSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Refrigerators != null)
            {
                project.Refrigerators.Add(fridge);
            }

            else
            {
                project.Refrigerators = new List<Refrigerator>();
                project.Refrigerators.Add(fridge);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            fridge.ProjectId = project.ProjectID;

            iUnitOfWork.RefrigeratorRepository.Insert(fridge);

            iUnitOfWork.Save();

            int fid = fridge.RefrigeratorId;

            Clients.All.createBathCallback(fridge.RefrigeratorSize, fid);
        }

        //----------------sink--------------------------------

        public void UpdateSink(Sink clientSink, int sinkId)
        {
            Clients.AllExcept(Context.ConnectionId).updateSink(clientSink, sinkId);
        }

        public void CreateSink(int projectId)
        {
            Sink sink = new Sink();
            sink.SinkSize = 200;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Sinks != null)
            {
                project.Sinks.Add(sink);
            }

            else
            {
                project.Sinks = new List<Sink>();
                project.Sinks.Add(sink);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            sink.ProjectId = project.ProjectID;

            iUnitOfWork.SinkRepository.Insert(sink);

            iUnitOfWork.Save();

            int sid = sink.SinkId;

            Clients.All.createSinkCallback(sink.SinkSize, sid);
        }

        //----------------stove--------------------------------

        public void UpdateStove(Stove clientStove, int stoveId)
        {
            Clients.AllExcept(Context.ConnectionId).updateStove(clientStove, stoveId);
        }

        public void CreateStove(int projectId)
        {
            Stove stove = new Stove();
            stove.StoveSize = 200;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Stoves != null)
            {
                project.Stoves.Add(stove);
            }

            else
            {
                project.Stoves = new List<Stove>();
                project.Stoves.Add(stove);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            stove.ProjectId = project.ProjectID;

            iUnitOfWork.StoveRepository.Insert(stove);

            iUnitOfWork.Save();

            int sid = stove.StoveId;

            Clients.All.createSinkCallback(stove.StoveSize, sid);
        }

        // ----------------sofa---------------------------------
        public void UpdateSofa(Sofa clientSofa, int sofaId)
        {
            Clients.AllExcept(Context.ConnectionId).updateSofa(clientSofa, sofaId);
        }

        public void CreateSofa(int projectId)
        {
            Sofa sofa = new Sofa();
            sofa.SofaSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Sofas != null)
            {
                project.Sofas.Add(sofa);
            }

            else
            {
                project.Sofas = new List<Sofa>();
                project.Sofas.Add(sofa);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            sofa.ProjectId = project.ProjectID;

            iUnitOfWork.SofaRepository.Insert(sofa);

            iUnitOfWork.Save();

            int sid = sofa.SofaId;

            Clients.All.createSofaCallback(sofa.SofaSize, sid);
        }

        // ----------------table---------------------------------
        public void UpdateTable(Table clientTable, int tableId)
        {
            Clients.AllExcept(Context.ConnectionId).updateTable(clientTable, tableId);
        }

        public void CreateTable(int projectId)
        {
            Table table = new Table();
            table.TableSize = 150;

            Project project = iUnitOfWork.ProjectRepository.GetById(projectId);

            if (project.Tables != null)
            {
                project.Tables.Add(table);
            }

            else
            {
                project.Tables = new List<Table>();
                project.Tables.Add(table);
            }

            iUnitOfWork.ProjectRepository.Update(project);

            table.ProjectId = project.ProjectID;

            iUnitOfWork.TableRepository.Insert(table);

            iUnitOfWork.Save();

            int tid = table.TableId;

            Clients.All.createSofaCallback(table.TableSize, tid);
        }
    }
}