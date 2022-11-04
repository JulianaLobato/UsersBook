﻿using System;
using UsersBook.Domain.Enums;

namespace UsersBook.Domain.Entities
{
    public class User : BaseEntity
    {
        private string _name;
        private string _lastName;
        private string _email;
        private DateTime _birthDate;
        private EducationLevel _educationLevel;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(_name))
                    throw new ArgumentException("The property Name can not be empity.");

                _name = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(_email))
                    throw new ArgumentException("The property Email can not be empity.");
            }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (_birthDate.Date == DateTime.MinValue)
                    throw new ArgumentException("Invalid Birth Date");

                if (_birthDate.Date >= DateTime.Today)
                    throw new ArgumentException("The property Birth Date can not be a date bigger the today");

                _birthDate = value;
            }
        }

        public EducationLevel EducationLevel
        {
            get => _educationLevel;
            set
            {
                if (!Enum.IsDefined(typeof(EducationLevel), value))
                    throw new ArgumentException("Invalid Education Level Enum");

                _educationLevel = value;
            }
        }
    }
}
