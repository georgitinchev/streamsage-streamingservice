using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicClassLibrary.NewFolder
{
    public static class UserValidation
    {
        public static string ValidateCreateInput(string username, string email, string password, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 6 || username.All(char.IsDigit))
            {
                return "Username should be at least 6 characters long and should not contain only numbers.\n";
            }
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                return "Please enter a valid email.\n";
            }
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return "Password should be at least 8 characters long.\n";
            }
            if (string.IsNullOrEmpty(firstName) || !Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "First name should start with a capital letter and should only contain letters.\n";
            }
            if (string.IsNullOrEmpty(lastName) || !Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "Last name should start with a capital letter and should only contain letters.\n";
            }
            return "";
        }

        public static string ValidateUpdateInput(string username, string email, string password, string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 6 || username.All(char.IsDigit))
            {
                return "Username should be at least 6 characters long and should not contain only numbers.\n";
            }
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                return "Please enter a valid email.\n";
            }
            if (!string.IsNullOrEmpty(password) && password.Length < 6)
            {
                return "Password should be at least 6 characters long if changing.\n";
            }
            if (string.IsNullOrEmpty(firstName) || !Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "First name should start with a capital letter and should only contain letters.\n";
            }
            if (string.IsNullOrEmpty(lastName) || !Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]*$"))
            {
                return "Last name should start with a capital letter and should only contain letters.\n";
            }
            return "";
        }
    }
}
