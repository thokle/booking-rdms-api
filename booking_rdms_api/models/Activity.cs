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
   public class Activity
    {
        public Activity()
        {
            this.MemberActivities = new HashSet<models.MemberActivity>();
            activityId = ObjectId.GenerateNewId();
           
        }

        
        [BsonId]
        private ObjectId activityId;
        private string type;
        private string name;
        private Nullable<int> maxparticipates;
        private Nullable<int> participantes;
        private Nullable<System.DateTime> startdate;
        private Nullable<System.DateTime> enddate;
        private Nullable<int> memberid;
        private Nullable<int> clubid;

        private Member Member;
        private Club Club;

        private ICollection<models.MemberActivity> memberActivities;

        public ObjectId ActivityId { get => activityId; set => activityId = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public int? Maxparticipates { get => maxparticipates; set => maxparticipates = value; }
        public int? Participantes { get => participantes; set => participantes = value; }
        public DateTime? Startdate { get => startdate; set => startdate = value; }
        public DateTime? Enddate { get => enddate; set => enddate = value; }
        public int? Memberid { get => memberid; set => memberid = value; }
        public int? Clubid { get => clubid; set => clubid = value; }
        public Member Member1 { get => Member; set => Member = value; }
        public Club Club1 { get => Club; set => Club = value; }
        public ICollection<MemberActivity> MemberActivities { get => memberActivities; set => memberActivities = value; }
    }
}
