using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class UserSettingsDTO
    {
        private string role;
        public string Role
        {
            get { return role; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Role cannot be empty.");
                }
                role = value;
            }
        }

        public string Theme { get; set; }
    }
}
