<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index3.aspx.cs" Inherits="Övning_31.Index3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(document).ready(function () {

            //alert('jQuery is working!');
            $("#myButton").click(function () {


                $.get("/Service/contact.aspx?action=getAllContacts")
                    .done(function (data) {
                        console.log(data);

                        var myJSON = JSON.parse(data);

                        for (var i = 0; i < myJSON.length; i++) {
                            $("#tableBody").append("<tr><td>" + myJSON[i].ID + "</td><td>" + myJSON[i].FirstName + "</td><td>" + myJSON[i].LastName + "</td></tr>");

                        }

                    });
            });

            $("#addButton").click(function () {

                //var firstName = document.getElementById("TestBoxLastName").innerText;
                var lastName = $("#TextBoxFirstName").val();
                alert(lastName);
                
                console.log(fn.val());
                console.log(lastName);
                $.get("/Service/contact.aspx?action=addContact&firstName=" + firstName + "&Lastname=" + lastName);

            });

        });

        

    </script>

    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Firstname</th>
                <th>Lastname</th>
                
            </tr>
        </thead>
<tbody id="tableBody">

</tbody>
    </table>
    <input type="text" id="fn" value="" />
    <%--<asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>--%>
    <input type="text"  ID="TextBoxFirstName" />
    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
    <input type="button" id="addButton" value="Add contact" /> 

    <input type="button" id="myButton" value="Get all data" /> 
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
