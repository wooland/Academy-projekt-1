using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KalleSql;
using Newtonsoft.Json;

namespace Övning_31.Service
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["action"] != null)
            {
                string action = Request["action"].ToString();

                if (action == "getAllContacts")
                {
                    List<Person> contacts = KalleSQL.ReadListFromSql();

                    JSONLiteral.Text = JsonConvert.SerializeObject(contacts);
                }
                if (action == "addContact")
                {
                    string firstName = Request["firstName"] != null ? Request["firstName"].ToString() : "";
                    string lastName = Request["lastName"] != null ? Request["lastName"].ToString() : "";
                    KalleSQL.AddContact(firstName, lastName, "12345");
                    JSONLiteral.Text = JsonConvert.SerializeObject("ok");
                }
            }

        }
    }
}