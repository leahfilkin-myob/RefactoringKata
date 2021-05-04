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
            CategorisePeoplePairsIntoAges(listOfAgeGaps);
            if(listOfAgeGaps.Count < 1)
            {
                return new PeopleAndTheirAgeGaps();
            }
            return FindPersonWithMostAppropriateAgeGap(listOfAgeGaps, choiceOfAgeGapLength);
        }

        private PeopleAndTheirAgeGaps FindPersonWithMostAppropriateAgeGap(List<PeopleAndTheirAgeGaps> listOfAgeGaps, ChoiceOfAgeGapLength choiceOfAgeGapLength)
        {
            var ageGapToReturn = listOfAgeGaps[0];
            foreach (var ageGap in listOfAgeGaps)
            {
                if (choiceOfAgeGapLength == ChoiceOfAgeGapLength.SmallestAgeGap
                    && ageGap.DifferenceInAge < ageGapToReturn.DifferenceInAge
                    || choiceOfAgeGapLength == ChoiceOfAgeGapLength.LargestAgeGap
                    && ageGap.DifferenceInAge > ageGapToReturn.DifferenceInAge)
                {
                    ageGapToReturn = ageGap;
                }
            }
            return ageGapToReturn;

        }
        
        private void CategorisePeoplePairsIntoAges(List<PeopleAndTheirAgeGaps> listOfAgeGaps)
        {
            for(var i = 0; i < _people.Count - 1; i++)
            {
                for(var j = i + 1; j < _people.Count; j++)
                {
                    var pairsOfPeopleAndAgeGap = new PeopleAndTheirAgeGaps();
                    if(_people[i].BirthDate < _people[j].BirthDate)
                    {
                        pairsOfPeopleAndAgeGap.YoungerPerson = _people[i];
                        pairsOfPeopleAndAgeGap.OlderPerson = _people[j];
                    }
                    else
                    {
                        pairsOfPeopleAndAgeGap.YoungerPerson = _people[j];
                        pairsOfPeopleAndAgeGap.OlderPerson = _people[i];
                    }
                    pairsOfPeopleAndAgeGap.DifferenceInAge = pairsOfPeopleAndAgeGap.OlderPerson.BirthDate - pairsOfPeopleAndAgeGap.YoungerPerson.BirthDate;
                    listOfAgeGaps.Add(pairsOfPeopleAndAgeGap);
                }
            }
        }
    }
}