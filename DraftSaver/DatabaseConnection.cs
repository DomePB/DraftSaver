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

        private void Open() {

            cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =F:\Visual Studios Projects\DraftSaver\DraftSaver\Database1.mdf; Integrated Security = True;");
            try
            {
                cnn.Open();
                Console.WriteLine("Sql Connetion Open successful");
            }
            catch (Exception)
            {

                
            }
        
        }
        private void Close() {
            try
            {
                cnn.Close();
                Console.WriteLine("Sql Connection Closed");
            }
            catch (Exception)
            {

              
            }
        }

        public void Save(string[] picks) 
        {
            Open();
            SqlCommand matchCommand = new SqlCommand($"INSERT INTO SavedDrafts(B1Pick,B2Pick,B3Pick,B4Pick,B5Pick,R1Pick,R2Pick,R3Pick,R4Pick,R5Pick) VALUES ('{picks[0]}','{picks[1]}','{picks[2]}','{picks[3]}','{picks[4]}','{picks[5]}','{picks[6]}','{picks[7]}','{picks[8]}','{picks[9]}')",cnn);
            matchCommand.ExecuteNonQuery();
            Close();
        }
            
    }
}
