using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlog
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private readonly Context Context = new Context();
        public List<Education> Educations { get; set; }
        public List<Skills> Skills { get; set; }
        public List<MyBlog.Models.Contact> Contacts { get; set; }
        public List<Models.WHAT_CAN__I_DO> wHAT_CAN__I_DOs { get; set; }
        public List<Models.ProjectSClientsS> ProjectSClientsS { get; set; }
        public List<Models.Contact_Details> Contact_Details { get; set; }
        public List<Models.Feedback> Feedbacks { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Educations = Context.Educations.ToList();
            Skills = Context.Skills.ToList();
            Contacts = Context.Contacts.ToList();
            wHAT_CAN__I_DOs = Context.wHAT_CAN__I_DOs.ToList();
            ProjectSClientsS = Context.ProjectSClientsSes.ToList();
            Contact_Details = Context.Contact_Details.ToList();
            Feedbacks = Context.Feedbacks.ToList();
        }
    }
}