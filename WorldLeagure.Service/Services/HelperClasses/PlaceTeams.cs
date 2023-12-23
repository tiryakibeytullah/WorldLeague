using WorldLeagure.Core.Entities;
using WorldLeagure.Core.ViewModels;

namespace WorldLeagure.Service.Services.HelperClasses
{
    public static class PlaceTeams
    {
        public static List<DrawReportViewModel> CreateDrawLost(Dictionary<Country, List<Team>> countriesWithTeams, List<Group> groups, int groupCount)
        {
            List<DrawReportViewModel> resultViewModels = new();
            resultViewModels.AddRange(groups.Select(g => new DrawReportViewModel() { Group = g, Teams = new List<Team>() }));
            for (int i = 0; i < groupCount; i++)
            {
                foreach (var country in countriesWithTeams.Keys)
                {
                    //Grup sayısı 8 ise 4'er takım olacak,
                    if (groupCount == 8 && resultViewModels[i].Teams.Count == 4)
                        break;

                    //Gruptaki ilgili takım varse geç,
                    if (countriesWithTeams[country].Any(c => resultViewModels.Any(r => r.Teams.Contains(c))))
                        continue;

                    Team? team = countriesWithTeams[country].FirstOrDefault();
                    if (team != null)
                    {
                        countriesWithTeams[country].Remove(team);
                        resultViewModels[i].Teams.Add(team);
                    }
                }
            }

            return resultViewModels;
        }
    }
}
