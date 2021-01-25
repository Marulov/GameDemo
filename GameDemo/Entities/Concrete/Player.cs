using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities.Concrete
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string NationalityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DateOfBirthYear { get; set; }
    }
}
