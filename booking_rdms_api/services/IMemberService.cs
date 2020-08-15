using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking_rdms_api.models;
using MongoDB.Bson;

namespace booking_rdms_api.booking_rdms_api.services
{
    interface IMemberService
    {

         Task<models.Member> GetUserByUserNameAndEmail(String username, String email, String password);
        Task<models.Member> CreateOrUpDate(models.Member member);
        Task<List<UserPictures>> GetUserPictures(ObjectId memberid);
    }
}
