using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Participation4.Models
{
    public class ClubRepository
    {
        private List<ClubModel> clubs = new List<ClubModel>();

        public ClubRepository()
        {
            clubs.Add(new ClubModel(0, "Chess", "Jim"));
            clubs.Add(new ClubModel(1, "Math", "Ross"));
            clubs.Add(new ClubModel(2, "Speech", "Kara"));
        }

        public List<ClubModel> getAllClubs()
        {
            return clubs;
        }
        public ClubModel getOneClub(int index)
        {
            return clubs[index];
        }

        public void deleteCLub(int id)
        {
            clubs.Remove(clubs[id]);
        }
    }
}
