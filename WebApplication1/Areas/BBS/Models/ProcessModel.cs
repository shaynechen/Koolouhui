using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koo.Web.Areas.BBS.Models
{
    public class ProcessModel
    {
        public Post Post { get; set; }

        public IList<PostType> PostTypeList { get; set; }

        //public Dictionary<int, PostType> PostTypeDic = new Dictionary<int, PostType>();
        
        
    }
}