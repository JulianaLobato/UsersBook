using System;

namespace UsersBook.Domain.Entities
{
    public class BaseEntity
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                if (_id > -1)
                    throw new ArgumentException("Invalid Id");

                _id = value;
            }
        }
    }
}
