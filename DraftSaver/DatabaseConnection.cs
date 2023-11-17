using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftSaver
{
     class DatabaseConnection
    {
        private SqlConnection cnn;

        public void Open() {

            cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =F:\Visual Studios Projects\DraftSaver\DraftSaver\Database1.mdf; Integrated Security = True;");
            try
            {
                cnn.Open();
                Console.WriteLine("Sql Connetion Open successful");
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        private void Close() { }
        
    }
}
