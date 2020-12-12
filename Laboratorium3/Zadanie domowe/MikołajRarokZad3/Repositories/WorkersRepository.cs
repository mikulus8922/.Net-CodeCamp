using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public class WorkersRepository : Repository, IWorkersRepository
    {    
        public DataTable GetWorkers()
        {
            string getWorkersQuery = "SELECT Workers.Id, Workers.FirstName, Workers.LastName, WorkersLoginData.WorkPosition FROM Workers JOIN WorkersLoginData ON Workers.AccountId=WorkersLoginData.Id;";

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(getWorkersQuery, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            Connection.Close();

            return table;
        }
        public void AddWorker(string firstName, string lastName, string workPosition)
        {
            string getAccountIdQuery = $"SELECT Id FROM WorkersLoginData WHERE WorkPosition='{workPosition}';";

            Connection.Open();

            SqlCommand commandGetWorkerAccountId = new SqlCommand(getAccountIdQuery, Connection);
            int accountId = (int)commandGetWorkerAccountId.ExecuteScalar();

            string addToWorkersQuery = $"INSERT INTO Workers VALUES('{firstName}', '{lastName}', '{accountId}');";

            SqlCommand commandAddWorker = new SqlCommand(addToWorkersQuery, Connection);
            commandAddWorker.ExecuteNonQuery();

            Connection.Close();
        }

        public void DeleteWorker(int workerId)
        {
            string removeFromWorkers = $"DELETE FROM Workers Where Id ='{workerId}';";

            Connection.Open();

            SqlCommand commandRemoveFromWorkers = new SqlCommand(removeFromWorkers, Connection);
            commandRemoveFromWorkers.ExecuteNonQuery();

            Connection.Close();
        }

        public void EditWorker(int workerId, string firstName, string lastName, string workPosition)
        {
            string getAccountIdQuery = $"SELECT Id FROM WorkersLoginData WHERE WorkPosition='{workPosition}';";

            Connection.Open();

            SqlCommand commandGetWorkerAccountId = new SqlCommand(getAccountIdQuery, Connection);
            int accountId = (int)commandGetWorkerAccountId.ExecuteScalar();

            string updateWorkersQuery = $"UPDATE Workers SET FirstName='{firstName}', LastName='{lastName}', AccountId='{accountId}' WHERE Id='{workerId}';";
            
            

            SqlCommand commandEditWorker = new SqlCommand(updateWorkersQuery, Connection);
            commandEditWorker.ExecuteNonQuery();

            Connection.Close();
        }


    }
}
