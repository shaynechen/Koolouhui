using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Koo.Web.Areas.BBS.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Koo.Web.Models.ApplicationUser CreatedUser { get; set; }

        public IList<Post> RepliedPosts { get; set; }

        public int BrowseNum { get; set; }

        public DateTime CreateDate { get; set; }

        //[NotMapped]//不关联数据库字段
        public int? Post_Id { get; set; }

        public int IsTop { get; set; }

        public PostType PostType { get; set; }

    }


    

}