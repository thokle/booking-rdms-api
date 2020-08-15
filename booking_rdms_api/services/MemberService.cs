using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using booking_rdms_api.models;
using booking_rdms_api.daos;
using MongoDB.Bson;

namespace booking_rdms_api.booking_rdms_api.services
{
    public class MemberService: IMemberService

    {
        MemberDao dao;

        public MemberService()
        {
            dao = new MemberDao();
        }

        public Task<models.Member> CreateOrUpDate(models.Member member)
        {
            return dao.CreateOrUpDate(member: member);
        }

        public Task<models.Member> GetUserByUserNameAndEmail(string username, string email, string password)
        {
            return dao.GetUserByUserNameAndEmail(username: username, email: email, password: password);
        }

        public Task<List<UserPictures>> GetUserPictures(ObjectId memberid)
        {
            return dao.GetUserPictures(memberid: memberid);
        }
    }
}
