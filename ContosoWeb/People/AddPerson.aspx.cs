using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Consoto.Service;

namespace ContosoWeb.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            

            Contoso.Model.People pe = new Contoso.Model.People()
            pe.FirstName = txtFirstName.Text;
            pe.LastName = txtLastName.Text;
            pe.MiddleName = txtMiddle.Text;
            pe.Age = Convert.ToInt32(TextAge.Text);
            pe.AddressLine1= TextAddress.Text;
            pe.State = ddlStates.SelectedValue;
            PeopleService peopleService = new PeopleService();
            

        }
    }
}