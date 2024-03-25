using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BazeDeDate.pages.clients
{
    public class CreateModel: PageModel
    {
        public ClientInfo ClientInfo = new ClientInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {

        }
        public void OnPost() 
        {
            ClientInfo.ClientID = Request.Form["ClientID"];
            ClientInfo.Nume = Request.Form["Nume"];
            ClientInfo.Prenume = Request.Form["Prenume"];
            ClientInfo.Parola = Request.Form["Parola"];
            ClientInfo.Telefon = Request.Form["Telefon"];
            ClientInfo.Email = Request.Form["Email"];
            ClientInfo.AdresaLivrare = Request.Form["AdresaLivrare"];
            ClientInfo.AdresaFacturare = Request.Form["AdresaFacturare"];

            if(ClientInfo.ClientID.Length==0)
            {
                errorMessage = "All fields are required";
                return;
            }
            successMessage = "Added new client";
            try
            {
                string connectionString = "";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql= "INSERT INTO Client(ClientID, Parola, Nume, Prenume, Telefon, Email, AdresaLivrare, AdresaFacturare)"+
                                " VALUES('$ClientID', '$Parola', '$Nume', '$Prenume', '$Telefon', '$Email', '$AdresaLivrare', '$AdresaFacturare')";
                    using (SqlCommand command = new SqlCommand(sql, connection)
                    {
                       /* command.Parameters.AddWithValue("$ClientID",ClientInfo.ClientID);
                        command.ExecuteNonQuery();*/
                    }
                }

            }
            catch(Exception ex) 
            {
                errorMessage = ex.Message;
                return;
            }

        }

    }
}
