using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_rdms_api.booking_rdms_api.services
{
    interface IClubService
    {
        Task<models.Club> GetClub(string name);
        Task<int> CreateOrUpDate(models.Club club);
        Task<Tuple<models.Club, models.Member, int>> AddMemberToClub(int memberid, int clubid);
         }

}
