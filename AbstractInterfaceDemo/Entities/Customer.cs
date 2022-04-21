using System;

namespace AbstractInterfaceDemo.Entities
{
    class Customer:IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfTime { get; set; }
        public string NationalID { get; set; }

    }
}
