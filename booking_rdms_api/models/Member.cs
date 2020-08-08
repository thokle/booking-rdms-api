using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_rdms_api.models
{

    public class Member
    {

        public Member()
        {
            activities = new List<Activity>();

        }
        private int memberId;
        private string firstname;
        private string lastname;
        private string middelname;
        private Nullable<System.DateTime> birthdate;
        private Nullable<int> clubid;
        private string username;
        private string password;
        private string email;
        private string email2;
        private int phone;

        private List<models.Activity> activities;

        private List<models.Address> addresses;

        private models.MemberActivity memberActivity;

        private List<models.Paymentreport> paymentreports;

        private List<models.UserPictures> userPictures;

        private List<models.Card> Cards;
        private models.Club Club { get; set; }
        public int MemberId { get => memberId; set => memberId = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Middelname { get => middelname; set => middelname = value; }
        public DateTime? Birthdate { get => birthdate; set => birthdate = value; }
        public int? Clubid { get => clubid; set => clubid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Email2 { get => email2; set => email2 = value; }
        public List<Activity> Activities { get => activities; set => activities = value; }
        public List<Address> Addresses { get => addresses; set => addresses = value; }
        public MemberActivity MemberActivity { get => memberActivity; set => memberActivity = value; }
        public List<Paymentreport> Paymentreports { get => paymentreports; set => paymentreports = value; }
        public List<UserPictures> UserPictures { get => userPictures; set => userPictures = value; }
        public List<Card> Cards1 { get => Cards; set => Cards = value; }
        public int Phone { get => phone; set => phone = value; }
    }
  
}
