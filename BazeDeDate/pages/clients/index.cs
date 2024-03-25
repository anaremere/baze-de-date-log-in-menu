using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDate.pages.clients
{
    public List<ClientInfo> listClients = new List<ClientInfo>();
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            try
            {
                string connectionString = "copy connection string dar nu merge nu se poate";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Client";
                    using (SqlCommand command = new SqlCommand(sql,connection)) 
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read()) 
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.ClientID=""+reader.GetString(1);
                                clientInfo.Nume=reader.GetString(2);
                                clientInfo.Prenume=reader.GetString(3); 
                                clientInfo.Parola   =reader.GetString(4);
                                clientInfo.Telefon=reader.GetString(5);
                                clientInfo.Email=reader.GetString(6);
                                clientInfo.AdresaLivrare=reader.GetString(7);
                                clientInfo.AdresaFacturare=reader.GetString(8);
                            }
                            listClients.Add(ClientInfo);

                        }
                    }
                } 
            }
            catch(Exception ex) 
            {

            }
        }
    }

    public class ClientInfo
    {
        public string ClientID;
        public string Nume;
        public string Prenume;
        public string Parola;
        public string Telefon;
        public string Email;
        public string AdresaLivrare;
        public string AdresaFacturare;
    }
}
