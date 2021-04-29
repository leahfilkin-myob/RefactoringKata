using System.Collections.Generic;

namespace Algorithm
{
    public class AgeGapCalculator
    {
        private readonly List<Person> _people;

        public AgeGapCalculator(List<Person> people)
        {
            _people = people;
        }

        public PeopleAndTheirAgeGaps FindAgeGap(ChoiceOfAgeGapLength choiceOfAgeGapLength)
        {
            var listOfAgeGaps = new List<PeopleAndTheirAgeGaps>();

            for(var i = 0; i < _people.Count - 1; i++)
            {
                for(var j = i + 1; j < _people.Count; j++)
                {
                    var r = new PeopleAndTheirAgeGaps();
                    if(_people[i].BirthDate < _people[j].BirthDate)
                    {
                        r.YoungerPerson = _people[i];
                        r.OlderPerson = _people[j];
                    }
                    else
                    {
                        r.YoungerPerson = _people[j];
                        r.OlderPerson = _people[i];
                    }
                    r.DifferenceInAge = r.OlderPerson.BirthDate - r.YoungerPerson.BirthDate;
                    listOfAgeGaps.Add(r);
                }
            }

            if(listOfAgeGaps.Count < 1)
            {
                return new PeopleAndTheirAgeGaps();
            }

            PeopleAndTheirAgeGaps mostAppropriateAgeGap = listOfAgeGaps[0];
            foreach(var ageGap in listOfAgeGaps)
            {
                switch(choiceOfAgeGapLength)
                {
                    case ChoiceOfAgeGapLength.SmallestAgeGap:
                        if(ageGap.DifferenceInAge < mostAppropriateAgeGap.DifferenceInAge)
                        {
                            mostAppropriateAgeGap = ageGap;
                        }
                        break;

                    case ChoiceOfAgeGapLength.LargestAgeGap:
                        if(ageGap.DifferenceInAge > mostAppropriateAgeGap.DifferenceInAge)
                        {
                            mostAppropriateAgeGap = ageGap;
                        }
                        break;
                }
            }

            return mostAppropriateAgeGap;
        }
    }
}