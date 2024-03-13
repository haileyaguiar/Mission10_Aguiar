using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // Add this namespace

namespace Mission10_Aguiar.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;

        // Constructor
        public EFBowlingRepository(BowlingLeagueContext bowlingContext)
        {
            _bowlingContext = bowlingContext;
        }

        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _bowlingContext.Bowlers
                .Include(b => b.Team) // Include the Team navigation property
                .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
                .ToList(); // Execute query and return as list
        }
    }
}

