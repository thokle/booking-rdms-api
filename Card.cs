//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace booking_rdms_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class Card
    {
        public int cardid { get; set; }
        public string cardtype { get; set; }
        public Nullable<int> memberid { get; set; }
        public Nullable<int> cardnumber { get; set; }
        public Nullable<int> endmonth { get; set; }
        public Nullable<int> endyear { get; set; }
        public Nullable<int> controlciffre { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
