using System;

namespace AgeGapCalculator
{
    public class AgeGapPair
    {
        public Person YoungerPerson { get; set; }
        public Person OlderPerson { get; set; }
        public TimeSpan DifferenceInAge { get; set; }
    }
}