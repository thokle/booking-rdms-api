using System;
using System.Threading.Tasks;
using booking_rdms_api.booking_rdms_api.daos;
namespace booking_rdms_api.booking_rdms_api.services
{
    public class ClubService: IClubService
    {
        private ClubDao clubDao;
        public ClubService()
        {
            clubDao = new ClubDao();
        }

        public Task<Tuple<models.Club, models.Member, int>> AddMemberToClub(int memberid, int clubid)
        {

            return clubDao.AddMemberToClub(memberid: memberid, clubid: clubid);
        }

        public Task<int> CreateOrUpDate(models.Club member)
        {
            return clubDao.CreateOrUpdate(member);
        }

        public Task<models.Club> GetClub(string name)
        {
            return clubDao.GetClub(name: name);
        }
    }
}
