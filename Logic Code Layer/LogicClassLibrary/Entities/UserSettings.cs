using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
    public class UserSettings
    {
        private string role;

        public string Role
        {
            get { return role; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Role cannot be empty.");
                }
                role = value;
            }
        }

        public string Theme { get; private set; } = "Light";

        public UserSettings(string role)
        {
            Role = role;
        }

        public UserSettings()
        {
            role = "User";
        }

        public void ModifyRole(string newRole)
        {
            Role = newRole;
        }

        public void ModifyTheme(string newTheme)
        {
            if (string.IsNullOrEmpty(newTheme))
            {
                throw new ArgumentException("Theme cannot be empty.");
            }
            Theme = newTheme;
        }

        public override string ToString()
        {
            return $"Role: {Role}, Theme: {Theme}";
        }
    }
}
