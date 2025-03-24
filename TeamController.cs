using Formula1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.Controllers
{
    public class TeamController
    {
        Formula1Context context= new Formula1Context();
        public async Task<List<Team>> GetAllTeams()
        {
            var teams = await context.Teams.ToListAsync<Team>();
            return teams;
        }
        public async Task<Team> GetTeamById(int teamId)
        {
            var teams = await context.Teams.FirstOrDefaultAsync(t => t.TeamId == teamId);
            return teams;
        }
        public async Task<List<Team>> GetTeamsByCountry(string country)
        {
            var teams=await context.Teams.Where(t=>t.Country==country)
                                         .ToListAsync();
            return teams;
        }
        public async Task<Team> GetOldestTeam()
        {
            var teams = await context.Teams.OrderBy(t => t.FoundationYear)
                                           .FirstOrDefaultAsync();
            return teams;
            
        }
    }
}
