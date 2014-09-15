using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Koo.Web.Areas.BBS.Models
{
    public class PostViewModel:Post
    {
        public int? ReplyPost_Id { get; set; }

    }
}