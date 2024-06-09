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
        public string Role { get; private set; } = "User";
        public string Theme { get; private set; } = "Light";
        public UserSettings(string role)
        {
            if (string.IsNullOrEmpty(role))
            {
                throw new ArgumentException("Role cannot be empty.");
            }
            Role = role;
        }
        public UserSettings()
        {
        
        }
        public void ModifyRole(string newRole)
        {
            if (string.IsNullOrEmpty(newRole))
            {
                throw new ArgumentException("Role cannot be empty.");
            }
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
