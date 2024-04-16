using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    namespace DataAccessLibrary
    {
        public class UserDAL : BaseDAL
        {
            public UserDAL(string connectionString) : base(connectionString)
            {
            }

            public void CreateUser(UserDTO user)
            {
                // Implement your logic here
                throw new NotImplementedException();
            }

            public UserDTO ReadUser(int userId)
            {
                // Implement your logic here
                throw new NotImplementedException();
            }

            public void UpdateUser(UserDTO user)
            {
                // Implement your logic here
                throw new NotImplementedException();
            }

            public void DeleteUser(int userId)
            {
                // Implement your logic here
                throw new NotImplementedException();
            }
        }
    }
}
