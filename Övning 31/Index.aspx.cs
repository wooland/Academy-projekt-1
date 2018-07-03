using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KalleSql;
using Newtonsoft.Json;


namespace Övning_31
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Person> contacts = KalleSQL.ReadListFromSql();


            LiteralContacts.Text = JsonConvert.SerializeObject(contacts);


            //string contactTable = "<table><thead><tr><td>Firstname</td><td>Lastname</td><td>SSN</td></tr></thead>";

            //contactTable += "<tbody>";
            //foreach (var p in KalleSQL.ReadListFromSql())
            //{
            //    contactTable += $"<tr><td><a href='/Contact.aspx?cid={p.ID}'>{p.FirstName}</td><td>{p.LastName}</td><td>{p.Ssn}</td></a></tr>";
            //}

            //contactTable += "</tbody>";
            //contactTable += "</table>";

            //LiteralContacts.Text = contactTable;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}