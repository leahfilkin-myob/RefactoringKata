using System;
using System.Collections.Generic;

namespace AgeGapCalculator
{
    public class AgeGapCalculator
    {
        private readonly List<Person> _people;

        public AgeGapCalculator(List<Person> people)
        {
            if (people.Count < 2)
            {
                throw new ArgumentException("Less than two people were provided");
            }
            _people = people;
        }

        public AgeGapPair FindAgeGap(ChoiceOfAgeGapLength choiceOfAgeGapLength)
        {
            var listOfAgeGaps = CategorisePeoplePairsIntoAges();
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
        
        private List<AgeGapPair> CategorisePeoplePairsIntoAges()
        {
            var listOfAgeGaps = new List<AgeGapPair>();
            for(var i = 0; i < _people.Count - 1; i++)
            {
                for(var j = i + 1; j < _people.Count; j++)
                {
                    var pairsOfPeopleAndAgeGap = new AgeGapPair();
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
            return listOfAgeGaps;
        }
    }
}