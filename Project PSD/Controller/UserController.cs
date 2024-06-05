using Project_PSD.Handlers;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project_PSD.Controller
{
    public class UserController
    {
        public static void Main(string[] args)
        {
            var userrepo = new UserRepository();
            var userContext = new UserContext();
            bool isNameUnique;
            var userModel = new UserModel
            {
                Name = GetValidatedInput("Name", userContext, out isNameUnique),
                DOB = GetValidatedDate("DOB"),
                Gender = GetValidatedInput("Gender"),
                Address = GetValidatedInput("Address"),
                Password = GetValidatedPassword("Password"),
                Phone = GetValidatedInput("Phone"),
                Role = GetValidatedInput("Role")
            };

            if (isNameUnique)
            {
                UserHandler.insertUser(userModel.Id,userModel.Name, userModel.Gender, userModel.DOB, userModel.Phone, userModel.Address, userModel.Password, userModel.Role);
                Console.WriteLine("User successfully added.");
            }
            else
            {
                Console.WriteLine("Name must be unique among the user's name.");
            }
        }
        public static string GetValidatedInput(string fieldName, UserContext context, out bool isUnique)
        {
            isUnique = true;
            string input;
            while (true)
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"{fieldName} is required.");
                    continue;
                }

                if (fieldName == "Name")
                {
                    if (input.Length < 5 || input.Length > 50)
                    {
                        Console.WriteLine($"{fieldName} must be between 5 and 50 characters.");
                        continue;
                    }

                    if (context != null && context.Users.Any(u => u.Name == input))
                    {
                        Console.WriteLine($"{fieldName} must be unique.");
                        isUnique = false;
                        break;
                    }
                }

                break;
            }
            return input;
        }

        public static string GetValidatedInput(string fieldName)
        {
           string input;
           while (true)
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"{fieldName} is required.");
                    continue;
                }

                break;
            }
            return input;
        }

        public static DateTime GetValidatedDate(string fieldName)
        {
            DateTime date;
            while (true)
            {
                Console.Write($"{fieldName} (yyyy-mm-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    var age = DateTime.Today.Year - date.Year;
                    if (date > DateTime.Today.AddYears(-age)) age--;
                    if (age >= 1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User must be at least 1 year old.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
            }
            return date;
        }

        public static string GetValidatedPassword(string fieldName)
        {
            string input;
            while (true)
            {
                Console.Write($"{fieldName}: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"{fieldName} is required.");
                    continue;
                }

                if (!Regex.IsMatch(input, @"^[a-zA-Z0-9]*$"))
                {
                    Console.WriteLine($"{fieldName} must be alphanumeric.");
                    continue;
                }

                break;
            }
            return input;
        }

        public class UserContext
        {
            public List<UserModel> Users { get; set; } = new List<UserModel>();
        }

        public class UserModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Role { get; set; }
        }
    }
}
