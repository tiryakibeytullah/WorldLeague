using AutoMapper;
using WorldLeague.API.Features.Commands.Countries.CreateCountry;
using WorldLeague.API.Features.Commands.Countries.UpdateCountry;
using WorldLeague.API.Features.Commands.DrawReports.CreateDrawReport;
using WorldLeague.API.Features.Commands.Groups.CreateGroup;
using WorldLeague.API.Features.Commands.Groups.UpdateGroup;
using WorldLeague.API.Features.Commands.Teams.CreateTeam;
using WorldLeague.API.Features.Commands.Teams.UpdateTeam;
using WorldLeague.API.Features.Queries.Countries.GetByIdCountry;
using WorldLeague.API.Features.Queries.DrawReports.GetByIdDrawReport;
using WorldLeague.API.Features.Queries.Groups.GetByIdGroup;
using WorldLeague.API.Features.Queries.Teams.GetByIdTeam;
using WorldLeague.API.ViewModels;
using WorldLeagure.Core.Entities;
using WorldLeagure.Core.ViewModels;

namespace WorldLeague.API
{
    public class WorldLeagueAutoMapperProfile : Profile
    {
        public WorldLeagueAutoMapperProfile()
        {
            #region Country Mapping
            CreateMap<Country, CreateCountryCommandRequest>().ReverseMap();
            CreateMap<Country, GetByIdCountryQueryResponse>().ReverseMap();
            CreateMap<Country, UpdateCountryCommandRequest>().ReverseMap();
            #endregion


            #region Team Mapping
            CreateMap<CreateTeamCommandRequest, Team>().ReverseMap();
            CreateMap<CreateTeamCommandRequest, Team>().ReverseMap();
            CreateMap<UpdateTeamCommandRequest, Team>().ReverseMap();
            CreateMap<Team, GetByIdTeamQueryResponse>().ReverseMap();
            #endregion

            #region Group Mapping
            CreateMap<CreateGroupCommandRequest, Group>().ReverseMap();
            CreateMap<UpdateGroupCommandRequest, Group>().ReverseMap();
            CreateMap<Group, GetByIdGroupQueryResponse>().ReverseMap();
            #endregion

            #region DrawReport Mapping
            CreateMap<CreateDrawReportCommandRequest, DrawReport>().ReverseMap();
            CreateMap<DrawReport, GetByUserDrawReportQueryResponse>().ReverseMap();
            #endregion

            CreateMap<DrawReportResponseViewModel, DrawReportViewModel>().ReverseMap();
        }
    }
}
