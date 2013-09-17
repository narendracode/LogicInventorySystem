using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApplicationLayer;
using ApplicationLayer.Controllers;

using System.Web.Script.Services;
using System.Web.Services;
using System.Web.Script.Serialization;

namespace PresentationLayer.m
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = ((User)Session["user"]);
            if (user != null)
            {
                if (user.user_type == 1 || user.user_type == 2) {
                    Response.Redirect("~/m/DepartmentHead/Stationeries.axpx");
                }
            }
            
        }

    }
}