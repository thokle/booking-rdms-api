using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using booking_rdms_api.models;

namespace booking_rdms_api.booking_rdms_api.services
{
    public class MemberService: IMemberService

    {
                public MemberService()
        {
        }

        public Task<int> CreateOrUpDate(models.Member member)
        {
            throw new NotImplementedException();
        }

        public Task<List<models.Member>> GetUserByUserNameAndEmail(string username, string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserPictures>> GetUserPictures(int memberid)
        {
            throw new NotImplementedException();
        }
    }
}
