using System;
using System.Threading.Tasks;
using booking_rdms_api.booking_rdms_api.daos;
using MongoDB.Bson;

namespace booking_rdms_api.booking_rdms_api.services
{
    public class ClubService: IClubService
    {
        private ClubDao clubDao;
        public ClubService()
        {
            clubDao = new ClubDao();
        }

        public Task<Tuple<models.Club, models.Member, int>> AddMemberToClub(ObjectId memberid, ObjectId clubid)
        {

            return clubDao.AddMemberToClub( memberid, clubid);
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
