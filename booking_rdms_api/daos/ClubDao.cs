using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_rdms_api.booking_rdms_api.daos
{
    class ClubDao
    {
        private bookiEntities bookiEntities;


        public ClubDao()
        {
            bookiEntities = new bookiEntities();
        }

        public async Task<models.Club> GetClub(string name)
        {
            try
            {
                return await bookiEntities.Clubs.Where(w => w.name.Equals(name.Trim())).Select(e => new models.Club() {

                }).FirstOrDefaultAsync();
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Tuple<models.Club, models.Member, int>> AddMemberToClub(int memberid, int clubid)
        {
            try
            {
                var club = bookiEntities.Clubs.Where(m => m.clubId == clubid).FirstOrDefaultAsync();

                var member = await club.ContinueWith<Member>(c =>
                {
                    return bookiEntities.Members.Where(me => me.memberId == memberid).FirstOrDefault();
                }).ContinueWith( re =>
                {
                    re.Result.clubid = clubid;
                    club.Result.Members.Add(re.Result);
                    bookiEntities.Clubs.AddOrUpdate(club.Result);
                    bookiEntities.Members.AddOrUpdate(re.Result);
                    return re;
                });

        
                var res = await bookiEntities.SaveChangesAsync();
                var tmp = new Tuple<models.Club, models.Member, int>(ConvertToClubModel(club.Result), ConvertToMemberModel(member),res);
                return await Task.FromResult(tmp);
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

        private Club Convert(models.Club club)
        {
            return new Club()
            {


            };
        }

        private static models.Club ConvertToClubModel(Club club) {
            return new models.Club()
            {

            };

        }

        private static models.Member ConvertToMemberModel(Member member)
        {
            return new models.Member()
            {

            };
        }
    }
}
