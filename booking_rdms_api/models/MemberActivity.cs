namespace booking_rdms_api.models
{
  
    public class MemberActivity
    {

        private int activityid;
        private int memberId;

        private Activity activity;
        private Member member;

        public int Activityid { get => activityid; set => activityid = value; }
        public int MemberId { get => memberId; set => memberId = value; }
        public Activity Activity { get => activity; set => activity = value; }
        public Member Member { get => member; set => member = value; }
    }
}