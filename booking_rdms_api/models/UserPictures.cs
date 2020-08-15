using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_rdms_api.models
{
  public class UserPictures
    {

        private int pictureid { get; set; }
        private Nullable<int> memberid { get; set; }
        private string pic_url { get; set; }
        private string pic_min { get; set; }

        private models.Member Member { get; set; }

        
        

    }
}
