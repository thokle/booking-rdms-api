using booking_rdms_api.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_rdms_api.daos
{
    class UserDao
    {
        private bookiEntities bookiEntities;

        public UserDao()
        {
            bookiEntities = new bookiEntities();
            bookiEntities.Configuration.LazyLoadingEnabled = true;
        }


        public async Task<List<models.Member>> GetUserByUserNameAndEmail(String username, String email, String password)
        {
            try
            {
             return await bookiEntities.Members.Where(e => e.username.Equals(username) && e.email.Equals(email) && e.password.Equals(password)).Select(m => new models.Member()
             {
              Firstname = m.firstname,
              Lastname = m.lastname,
              Middelname = m.middelname,
              Username = m.username,
              Password = m.password,
              Email = m.email,
             
             }).ToListAsync();
         

            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> CreateOrUpDate(models.Member member)
        {
            try
            {
                bookiEntities.Members.AddOrUpdate(Convert(member: member));
               return await bookiEntities.SaveChangesAsync();
             
            }catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Task<List<UserPictures>> GetUserPictures(int memberid)
        {
            try
            {
              return  bookiEntities.UserPictures.Where(w => w.memberid == memberid).Select(m => new models.UserPictures() { }).ToListAsync();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private Member Convert(models.Member  member)
        {
            return new Member()
            {
                firstname = member.Firstname,
                lastname = member.Lastname,
                middelname = member.Middelname,
                username = member.Username,
                password = member.Password,
                email = member.Email,
                email2 = member.Email2,
                phone = member.Phone
            };
        }



    }
}
