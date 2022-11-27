using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace msvload.Entities
{
    public enum Gender
    {
        Male,
        Female
    }
    
    public enum AccountType
    {
        Student,
        Teacher
    }

    public enum Country
    {
        Austria,
        Belgium,
        Bulgaria,
        Croatia,
        Republic_of_Cyprus,
        Czech_Republic,
        Denmark,
        Estonia,
        Finland,
        France,
        Germany,
        Greece,
        Hungary,
        Ireland,
        Italy,
        Latvia,
        Lithuania,
        Luxembourg,
        Malta,
        Netherlands,
        Poland,
        Portugal,
        Romania,
        Slovakia,
        Slovenia,
        Spain,
        Sweden,
        Russia,
        Ukraine
    }

    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [MaxLength(256)]
        public string UserName { get; set; }

        [MaxLength(64)]
        public string FirstName { get; set; }

        [MaxLength(64)]
        public string LastName { get; set; }
        
        public Gender Gender { get; set; }

        public Country Country { get; set; }

        public Code UserCode { get; set; }

        //public AccountType AccountType { get; set; }

        //If account type is teacher
        //public Teacher Teacher { get; set; }

        //If account type is student
        //public Student Student { get; set; }

        public bool GetNotifications { get; set; }

        public long? CorrectAnswers { get; set; } // count of all correct answers of User
        public long? WrongAnswers { get; set; }   // count of all incorrect answers of User
        public long? WordsLearnt { get; set; }

        public User() { }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public User(string userName)
        {
            UserName = userName;
        }

        public User(string email, string password, string userName) : this(email, password)
        {
            UserName = userName;
        }

        public override string ToString()
        {
            return $"Email: {Email}, Password: {Password}, UserName: {UserName}," +
                $" Correct answers: {CorrectAnswers}, incorrect answers: {WrongAnswers}";
        }

        public string[] CountriesList()
        {
            return Enum.GetNames(typeof(Country)).Cast<string>().ToArray();
        }
    }
}
