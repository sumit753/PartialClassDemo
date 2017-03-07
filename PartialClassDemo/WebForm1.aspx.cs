using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClassDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Name with Id=3 "+company[3]);
            company[2] = "SUmit Karma";
            Response.Write("<br/>");
            Response.Write("Name with Id=2 " + company[2]);


            Response.Write("<br/>");
            Response.Write("<br/>");


            Response.Write("Indexer Overloading Demo");

            Response.Write("Before Update");
            Response.Write("<br/>");
            Response.Write("No of male employees in the company : " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("No of Female employees in the company : " + company["Female"]);
            Response.Write("<br/>");

            company["Male"] = "Female";

            Response.Write("After Update");
            Response.Write("<br/>");
            Response.Write("No of male employees in the company : " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("No of Female employees in the company : " + company["Female"]);
        }
    }
}