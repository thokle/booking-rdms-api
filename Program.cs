using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booking_rdms_api.daos;
using MongoDB.Driver;

namespace booking_rdms_api
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            daos.MemberDao dao = new MemberDao();

          var e =   dao.CreateOrUpDate(new models.Member
            {
                Firstname =  "Thomas"


            });
           
            
        }
    }
}
