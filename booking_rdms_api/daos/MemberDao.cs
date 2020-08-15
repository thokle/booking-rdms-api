using booking_rdms_api.models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace booking_rdms_api.daos
{
    public class MemberDao
    {
      
        private booking_rdms_api.utls.MongoDbDriver driver;
        private IMongoDatabase mongo { get; set; }
        private IMongoCollection<models.Member> mongoCollection { get; set; }
        public MemberDao()
        {
            Start();
        }

        private void Start()
        {
            driver = new booking_rdms_api.utls.MongoDbDriver();
            mongo = driver.Connect();
            mongoCollection = mongo.GetCollection<models.Member>("members");
            if (mongoCollection == null)
            {
                mongo.CreateCollection("members");
            }
        }


       

        public async Task<models.Member> GetUserByUserNameAndEmail(String username, String email, String password)
        {
            try
            {
               
                var filter = Builders<models.Member>.Filter.Where(s => s.Username.Equals(username) && s.Password.Equals(password));

                return await mongoCollection.FindAsync<models.Member>(filter) as models.Member;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

     
        public async Task <models.Member> CreateOrUpDate(models.Member member)
        {
            try
              
            {
               
                var filter = Builders<models.Member>.Filter.Where(s => s.Username.Equals(member.Username) && s.Password.Equals(member.Password));
               var m = await mongoCollection.FindAsync<models.Member>(filter: filter);
               var userMember =  m.FirstOrDefault<models.Member>();

                if (userMember !=null)
                {
                    userMember.Revision = userMember.Revision + 1;
                        await  mongoCollection.InsertOneAsync(userMember);
                    return userMember;
                }
                else {

                   await mongoCollection.InsertOneAsync(member);
                    return member;
                }

             
            }catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<List<UserPictures>> GetUserPictures(ObjectId memberid)
        {
            try
            {
                

                var filter = Builders<models.Member>.Filter.Where(s => s.Id == memberid );
                var res =  mongoCollection.Find<models.Member>(filter);

               var  member =  res.SingleAsync();
           
                 Debug.Assert(member != null, nameof(member) + " != null");
                 return await Task.FromResult<List<models.UserPictures>>(member.Result.UserPictures);
            
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
       



    }
}
