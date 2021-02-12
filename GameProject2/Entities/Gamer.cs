using GameProject2.Abstract;
using System;

namespace GameProject2.Entities
{
   public class Gamer : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
