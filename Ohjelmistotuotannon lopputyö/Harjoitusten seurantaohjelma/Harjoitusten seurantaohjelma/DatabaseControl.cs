using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Harjoitusten_seurantaohjelma
{
    public class DatabaseControl
    {
        public string yhteysTiedot; 
        public SqlConnection yhteys;

        public DatabaseControl()
        {

        }
        public bool connectDatabase()
        {

            
            yhteysTiedot = //lisää tähän oma tietokanta connection string!
            
            yhteys = new SqlConnection(yhteysTiedot);
            try
            {
                yhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                yhteys.Close();
                return false;
            }
        }

        public void disconnectDatabase()
        {
            yhteys.Close();
        }
    }
}
