using System;
using UsersBook.Domain.Enums;

namespace UsersBook.Domain.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public EducationLevel EducationLevel { get; set; }
    }
}
