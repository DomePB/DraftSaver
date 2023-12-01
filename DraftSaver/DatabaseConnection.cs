using System;
using System.Collections.Generic;
using System.Data;
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
            SqlCommand matchCommand = new SqlCommand("INSERT INTO SavedDrafts(B1Pick,B2Pick,B3Pick,B4Pick,B5Pick,R1Pick,R2Pick,R3Pick,R4Pick,R5Pick) VALUES(@B1pick,@B2pick,@B3pick,@B4pick,@B5pick,@R1pick,@R2pick,@R3pick,@R4pick,@R5pick)",cnn);
            matchCommand.Parameters.AddWithValue("@B1pick", picks[0]);
            matchCommand.Parameters.AddWithValue("@B2pick", picks[3]);
            matchCommand.Parameters.AddWithValue("@B3pick", picks[4]);
            matchCommand.Parameters.AddWithValue("@B4pick", picks[7]);
            matchCommand.Parameters.AddWithValue("@B5pick", picks[8]);
            matchCommand.Parameters.AddWithValue("@R1pick", picks[1]);
            matchCommand.Parameters.AddWithValue("@R2pick", picks[2]);
            matchCommand.Parameters.AddWithValue("@R3pick", picks[5]);
            matchCommand.Parameters.AddWithValue("@R4pick", picks[6]);
            matchCommand.Parameters.AddWithValue("@R5pick", picks[9]);

            matchCommand.ExecuteNonQuery();
            Close();
        }
        public DataTable LoadAllDrafts() { 
            Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SavedDrafts",cnn);
            DataTable drafts = new DataTable();
            adapter.Fill(drafts);
            Close();
            return drafts;
            
        }
        public Dictionary<string, int> getChampionPlayedCount() {

            Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Champion, COUNT(*) AS PickedCount\r\nFROM (\r\n    SELECT Champion = B1pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = B2pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = B3pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = B4pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = B5pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = R1pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = R2pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = R3pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = R4pick FROM SavedDrafts\r\n    UNION ALL\r\n    SELECT Champion = R5pick FROM SavedDrafts\r\n) AS PickedChampions\r\nWHERE Champion IS NOT NULL\r\nGROUP BY Champion ORDER BY PickedCount DESC;\r\n", cnn);
            DataTable drafts = new DataTable();
            adapter.Fill(drafts);
            Close();

            Dictionary<string,int> championCounts = new Dictionary<string,int>();

            foreach (DataRow row in drafts.Rows) {
                string champion = Convert.ToString(row["Champion"].ToString());
                int pickedCount = Convert.ToInt32(row["PickedCount"]);
                championCounts.Add(champion, pickedCount);
            }
            return championCounts;
        }
    }
}
