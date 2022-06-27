namespace ProblemsAlgoExpert.Arrays
{
    public static class TournamentWinner
    {
        #region solution one
        private static readonly int POINTS_WINNER = 3;

        public static string TournamentWinnerSolution1(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            Dictionary<string, int> winnersPoints = new Dictionary<string, int>();
            for (var idx = 0; idx < competitions.Count; idx++)
            {
                var teamWinner = results[idx];
                var teams = competitions[idx];
                var idxWinner = teamWinner == 1 ? 0 : 1;
                var nameTeamWinner = teams[idxWinner];
                if (winnersPoints.ContainsKey(nameTeamWinner))
                {
                    winnersPoints[nameTeamWinner] = winnersPoints[nameTeamWinner] + POINTS_WINNER;
                    continue;
                }

                winnersPoints.Add(nameTeamWinner, POINTS_WINNER);
            }

            var winner = winnersPoints.OrderByDescending(w => w.Value).First();
            return winner.Key;
        }
        #endregion

        #region solution two
        public static readonly int HOME_TEAM_WON = 1;

        public static string TournamentWinnerSolution2(List<List<string>> competitions, List<int> results)
        {
            string currentBestTeam = "";
            var scores = new Dictionary<string, int>();
            scores[currentBestTeam] = 0;

            for (int idx = 0; idx < competitions.Count; idx++)
            {
                List<string> competition = competitions[idx];
                int result = results[idx];
                string homeTeam = competition[0];
                string awayTeam = competition[1];

                string winningTeam = result == HOME_TEAM_WON ? homeTeam : awayTeam;

                UpdateScores(winningTeam, 3, scores);

                if (scores[winningTeam] > scores[currentBestTeam])
                {
                    currentBestTeam = winningTeam;
                }
            }
            return currentBestTeam;
        }

        private static void UpdateScores(string team, int points, Dictionary<string, int> scores)
        {
            if (!scores.ContainsKey(team))
            {
                scores[team] = 0;
            }

            scores[team] = scores[team] + points;
        }

        #endregion
    }
}
