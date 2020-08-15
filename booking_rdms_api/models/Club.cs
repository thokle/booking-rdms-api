using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace booking_rdms_api.models
{
    [Serializable]
    public class Club
    {


        public Club()
        {
            this.Activities = new List<models.Activity>();
            this.Adresses = new List<models.Address>();
            this.Members = new List<models.Member>();
            clubId = ObjectId.GenerateNewId();
        }

        [BsonId]
        private ObjectId clubId;
        private string name;
        private string type;
        private Nullable<System.DateTime> createdate;
        private Nullable<int> phone;


        private List<models.Activity> activities;

        private List<models.Address> adresses;
        private ClubPicture clubPicture;

        private List<Member> members;

        public ObjectId ClubId { get => clubId; set => clubId = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public DateTime? Createdate { get => createdate; set => createdate = value; }
        public int? Phone { get => phone; set => phone = value; }
        public List<Activity> Activities { get => activities; set => activities = value; }
        public List<Address> Adresses { get => adresses; set => adresses = value; }
        public ClubPicture ClubPicture { get => clubPicture; set => clubPicture = value; }
        public List<Member> Members { get => members; set => members = value; }
    }
}
