﻿namespace UsersBook.Domain.Entities
{
    public class BaseEntity
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
    }
}
