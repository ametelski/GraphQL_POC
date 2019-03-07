namespace GraphQL_POC_v1.Models
{
    using System;

    public class Human : Character
    {
        public DateTime DateOfBirth { get; set; }

        public string HomePlanet { get; set; }
    }
}
