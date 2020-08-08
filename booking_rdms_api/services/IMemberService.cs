using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking_rdms_api.models;

namespace booking_rdms_api.booking_rdms_api.services
{
    interface IMemberService
    {

         Task<List<models.Member>> GetUserByUserNameAndEmail(String username, String email, String password);
        Task<int> CreateOrUpDate(models.Member member);
        Task<List<UserPictures>> GetUserPictures(int memberid);
    }
}
