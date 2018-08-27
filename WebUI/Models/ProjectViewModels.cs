using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CreateProjectViewModel
    {
        public Project Project { get; set; }
    }

    public class OpenProjectViewModel
    {
        public Project Project { get; set; }
    }

    public class CreateOrJoinProjectViewModel
    {
        public string UserId { get; set; }

        public IEnumerable<Project> AvailableProjects { get; set; }

        public IEnumerable<Project> JoinedProjects { get; set; }
    }



    




}