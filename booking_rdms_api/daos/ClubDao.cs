using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace booking_rdms_api.booking_rdms_api.daos
{
    class ClubDao
    {
        private bookiEntities bookiEntities;
        private booking_rdms_api.utls.MongoDbDriver driver;
        private IMongoDatabase mongo { get; set; }
        private IMongoCollection<models.Club> mongoCollection { get; set; }

        public ClubDao()
        {
            Start();
        }
        
        
        private void Start()
        {
            driver = new booking_rdms_api.utls.MongoDbDriver();
            mongo = driver.Connect();
            mongoCollection = mongo.GetCollection<models.Club>("clubs");
            if (mongoCollection == null)
            {
                mongo.CreateCollection("clubs");
            }
        }


        public async Task<models.Club> GetClub(string name)
        {
            try
            {
                var filter = Builders<models.Club>.Filter.Where(e =>  e.Name.Equals(name) );

             var res  =   mongoCollection.FindAsync(filter);

             return  await res.Result.SingleOrDefaultAsync();

            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Tuple<models.Club, models.Member, int>> AddMemberToClub(ObjectId memberid, ObjectId clubid)
        {
            try
            {

                var filterClub = Builders<models.Club>.Filter.Where(e => e.ClubId.Equals(clubid));
                var filterMember = Builders<models.Member>.Filter.Where((member => member.Id.Equals(memberid)));
                
                
               var members =  mongo.GetCollection<models.Member>("members");
             
                return null;
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> CreateOrUpdate(models.Club club)
        {
            try
            {
                bookiEntities.Clubs.AddOrUpdate(Convert(club: club));
                return await bookiEntities.SaveChangesAsync();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Club Convert(models.Club club) => new Club()
        {
            name = club.Name,
            type = club.Type,
            createdate = club.Createdate
        };

        private static models.Club ConvertToClubModel(Club club) {
            return new models.Club()
            {
        
                Name = club.name,
                Members = ConvertToModelMembers(club.Members),
                Phone = club.phone,
                Activities = ConvertToModelActivity(club.Activities)
            };

        }

        private static models.Member ConvertToMemberModel(Member member)
        {
            return new models.Member()
            {

            };
        }

        private static List<models.Member> ConvertToModelMembers(ICollection<Member> members) {
            var res = new List<models.Member>();

            members.ToList().ForEach(s =>
            {
                

            });

            return res;
        }


        private static List<models.Activity> ConvertToModelActivity(ICollection<Activity> activities) {
            var res = new List<models.Activity>();

            activities.ToList().ForEach(a =>
            {

            });
            return res;
        }
    }
}
