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
    
    public partial class ClubPicture
    {
        public int clubpicid { get; set; }
        public Nullable<int> cludid { get; set; }
        public string eventname { get; set; }
        public string description { get; set; }
        public string picurl { get; set; }
    
        public virtual Club Club { get; set; }
    }
}
