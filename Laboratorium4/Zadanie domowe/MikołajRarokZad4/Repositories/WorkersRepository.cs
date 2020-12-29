using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad4.Repositories
{
    /// <summary>
    /// Publiczna klasa definiująca metodody związane z pracownikami 
    /// pozwalające na komunikowanie się z bazą danych i wyświetlanie ich
    /// </summary>
    public class WorkersRepository : Repository, IWorkersRepository
    {
        /// <summary>
        /// Metoda zwracająca tabelę
        /// pracownikami
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda pozwalająca dodać pracownika do bazy danych
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="workPosition"></param>
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

        /// <summary>
        /// Metoda pozwalająca na usunięcie pracownika z bazy danych
        /// </summary>
        /// <param name="workerId"></param>
        public void DeleteWorker(int workerId)
        {
            string removeFromWorkers = $"DELETE FROM Workers Where Id ='{workerId}';";

            Connection.Open();

            SqlCommand commandRemoveFromWorkers = new SqlCommand(removeFromWorkers, Connection);
            commandRemoveFromWorkers.ExecuteNonQuery();

            Connection.Close();
        }


        /// <summary>
        /// Metoda pozwalająca na edytowanie danych o pracowniku w bazie danych
        /// </summary>
        /// <param name="workerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="workPosition"></param>
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
