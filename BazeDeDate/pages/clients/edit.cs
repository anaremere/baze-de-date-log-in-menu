using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDate.pages.clients
{
    public class EditModel : PageModel
    {
        public ClientInfo ClientInfo =new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
            string ClientID = Request.Query["ClientID"];
            try 
            {
                string connectionString = "";
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    string sql = "SELECT * FROM CLIENT WHERE CliendID=$CliendID";
                    using (SqlCommand command = new SqlCommand(sql,connection)) 
                    {
                        if(reader.Read())
                        {
                            ClientInfo.ClientID = "" + reader.GetInt32(0);
                            ClientInfo.Nume =reader.GetInt32(0);
                            ClientInfo.Prenume = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                errorMessage = ex.Message;
            }
        }
        public void OnPost() 
        {
            ClientInfo.ClientID = request.Form["ClientID"];
            ClientInfo.Nume = request.Form["Nume"];
            ClientInfo.Prenume = request.Form["Prenume"];
            ClientInfo.Parola = request.Form["Parola"];

            if(ClientInfo.ClientID.Length ==0)
            {
                errorMessage = "All fields are required";
                return;
            }

            try
            {
                string connectionString = "";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open ();
                    string sql = "UPDATE Client SET Parola='$Parola',Nume='$Nume',Prenume='$Prenume',Telefon='$Telefon',Email='$Email',AdresaLivrare='$AdresaLivrare',AdresaFacturare='$AdresaFacturare'\r\nWHERE ClientID='$ClientID'";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        command.Parameters.AddWithValue("$ClientID", ClientInfo.ClientID);
                        command.Parameters.AddWithValue("$Nume", ClientInfo.Nume);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                errorMessage = ex.Message;
            }

            response.redirect("/Clients/index");
        }
    }
}