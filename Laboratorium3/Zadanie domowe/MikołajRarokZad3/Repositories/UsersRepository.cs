using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikołajRarokZad3.Repositories
{
    public class UsersRepository : Repository, IUsersRepository
    {
        public string Login(string login, string password)
        {
            string loginQuery = $"SELECT WorkPosition FROM WorkersLoginData WHERE Login='{login}' AND Password='{password}';";

            Connection.Open();

            SqlCommand loginCommand = new SqlCommand(loginQuery, Connection);
            string workPosition = (string)loginCommand.ExecuteScalar();

            Connection.Close();


            if (workPosition.Equals("SystemAdmin") || workPosition.Equals("Owner"))
                return "admin";
            if (workPosition.Equals("Receptionist"))
                return "receptionist";
            if (workPosition.Equals("CateringManager"))
                return "catering";

            return "brak";
        }
    }
}
