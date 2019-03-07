namespace GraphQL_POC_v1.Models
{
    using System;

    public class Droid : Character
    {
        public DateTimeOffset Created { get; set; }

        public TimeSpan ChargePeriod { get; set; }

        public string PrimaryFunction { get; set; }
    }
}
