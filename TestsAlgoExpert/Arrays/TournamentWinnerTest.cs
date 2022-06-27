using NUnit.Framework;
using System.Collections.Generic;
using ProblemsAlgoExpert.Arrays;

namespace TestsAlgoExpert.Arrays
{
    public class TournamentWinnerTest
    {
        public static readonly (List<List<string>> competitions, List<int> results, string winnerExpected)[] TypeCases =
        {
            (
                new List<List<string>>
                {
                    CreateCompetition("HTML", "C#"),
                    CreateCompetition("C#", "Python"),
                    CreateCompetition("Python", "HTML")
                },
                new List<int>{ 0, 0, 1 },
                "Python"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("HTML", "Java"),
                    CreateCompetition("Java", "Python"),
                    CreateCompetition("Python", "HTML")
                },
                new List<int>{ 0, 1, 1 },
                "Java"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("HTML", "Java"),
                    CreateCompetition("Java", "Python"),
                    CreateCompetition("Python", "HTML"),
                    CreateCompetition("C#", "Python"),
                    CreateCompetition("Java", "C#"),
                    CreateCompetition("C#", "HTML")
                },
                new List<int>{ 0, 1, 1, 1, 0, 1 },
                "C#"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("HTML", "Java"),
                    CreateCompetition("Java", "Python"),
                    CreateCompetition("Python", "HTML"),
                    CreateCompetition("C#", "Python"),
                    CreateCompetition("Java", "C#"),
                    CreateCompetition("C#", "HTML"),
                    CreateCompetition("SQL", "C#"),
                    CreateCompetition("HTML", "SQL"),
                    CreateCompetition("SQL", "Python"),
                    CreateCompetition("SQL", "Java")
                },
                new List<int>{ 0, 1, 1, 1, 0, 1, 0, 1, 1, 0 },
                "C#"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("Bulls", "Eagles")
                },
                new List<int>{ 1 },
                "Bulls"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("Bulls", "Eagles"),
                    CreateCompetition("Bulls", "Bears"),
                    CreateCompetition("Bears", "Eagles")
                },
                new List<int>{ 0, 0, 0 },
                "Eagles"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("Bulls", "Eagles"),
                    CreateCompetition("Bulls", "Bears"),
                    CreateCompetition("Bulls", "Monkeys"),
                    CreateCompetition("Eagles", "Bears"),
                    CreateCompetition("Eagles", "Monkeys"),
                    CreateCompetition("Bears", "Monkeys")
                },
                new List<int>{ 1, 1, 1, 1, 1, 1 },
                "Bulls"
            ),
            (
                new List<List<string>>
                {
                    CreateCompetition("AlgoMasters", "FrontPage Freebirds"),
                    CreateCompetition("Runtime Terror", "Static Startup"),
                    CreateCompetition("WeC#", "Hypertext Assassins"),
                    CreateCompetition("AlgoMasters", "WeC#"),
                    CreateCompetition("Static Startup", "Hypertext Assassins"),
                    CreateCompetition("Runtime Terror", "FrontPage Freebirds"),
                    CreateCompetition("AlgoMasters", "Runtime Terror"),
                    CreateCompetition("Hypertext Assassins", "FrontPage Freebirds"),
                    CreateCompetition("Static Startup", "WeC#"),
                    CreateCompetition("AlgoMasters", "Static Startup"),
                    CreateCompetition("FrontPage Freebirds", "WeC#"),
                    CreateCompetition("Hypertext Assassins", "Runtime Terror"),
                    CreateCompetition("AlgoMasters", "Hypertext Assassins"),
                    CreateCompetition("WeC#", "Runtime Terror"),
                    CreateCompetition("FrontPage Freebirds", "Static Startup")
                },
                new List<int>{ 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0 },
                "AlgoMasters"
            ),
        };

        private static List<string> CreateCompetition(string teamHome, string teamAway)
        {
            return new List<string> { teamHome, teamAway };
        }


        [Test]
        [TestCaseSource("TypeCases")]
        public void TournamentWinnerSolution1((List<List<string>> competitions, List<int> results, string winnerExpected) test)
        {
            string output = TournamentWinner.TournamentWinnerSolution1(test.competitions, test.results);
            Assert.True(output == test.winnerExpected);
        }

        [Test]
        [TestCaseSource("TypeCases")]
        public void TwoNumberSumSolution2((List<List<string>> competitions, List<int> results, string winnerExpected) test)
        {
            string output = TournamentWinner.TournamentWinnerSolution2(test.competitions, test.results);
            Assert.True(output == test.winnerExpected);
        }
    }
}
