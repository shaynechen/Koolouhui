﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Koo.Web.Areas.BBS.Models;
using Koo.Web.Models;
namespace Koo.Web.BBS.Controllers

{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public static int defaultPageSize = 2;

        //// 传入 page 参数 ( 透过 Model Binder 绑进来的 )     
        //public ActionResult Index(int? page)
        //{
        //    IQueryable<Post> posts =
        //        from post in db.Posts
        //        select post;

        //    // 计算出目前要显示第几页的资料 ( 因为 page 为 Nullable<int> 型别 )     
        //    int currentPageIndex = page.HasValue ? page.Value - 1 : 0;

        //    // 透过 ToPagedList 这个 Extension Method 将原本的资料转成 IPagedList<T>     
        //    return View(posts.ToPagedList(currentPageIndex, defaultPageSize));
        //}    

        public ActionResult Index(int pageIndex = 1)
        {
            IList<Post> data = db.Posts.ToList<Post>();
            PagingHelper<Post> postPaging = new PagingHelper<Post>(defaultPageSize, data);//初始化分页器
            postPaging.PageIndex = pageIndex;//指定当前页
            return View(postPaging);//返回分页器实例到视图
        }


        //// GET: BBS/Home
        //public ActionResult Index()
        //{
        //    return View(db.Posts.ToList());
        //}

        // GET: BBS/Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostViewModel post = (PostViewModel)db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            else 
            {
                post.BrowseNum += 1;
                //IList<Post> data = db.Posts.ToList<Post>();
                //string createUserName = User.Identity.Name;
                //IList<ApplicationUser> data1 = db.Users.ToList<ApplicationUser>();
                //ApplicationUser createUser = db.Users.First(u => u.UserName == createUserName);
                //if (createUser != null)
                //    post.CreatedUser = createUser;

                IList<Post> replyPost = db.Posts.Where(c => c.Post_Id != null && c.Post_Id == id).OrderByDescending(c => c.CreateDate).ToList<Post>();
                //foreach (Post replymodel in replyPost) 
                //{ 
                    
                //}
                post.RepliedPosts = replyPost;
                db.SaveChanges();
            }
            return View(post);
        }

        // GET: BBS/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Browser(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            else
            {
                post.BrowseNum += 1;
                db.SaveChanges();
            }
            return View(post);
        }

        /// <summary>
        /// 回复的方法
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reply([Bind(Include = "Id,Title,Content,CreatedUser,CreateDate,Post_Id")] Post post)
        {
            int replyId = post.Id;
            if (post!=null)
            {
                if (post.Id != 0)
                {
                    post.Post_Id = post.Id;
                }
                post.CreateDate = DateTime.Now;
                string createUserName = User.Identity.Name;
                ApplicationUser createUser = db.Users.First(u => u.UserName == createUserName);
                if (createUser != null)
                    post.CreatedUser = createUser;
                db.Posts.Add(post);
                db.SaveChanges();
            }
            return RedirectToAction("Details/" + replyId);
        }

        // POST: BBS/Home/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.CreateDate = DateTime.Now;
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }
        //public ActionResult Create([Bind(Include = "Id,Title,Content")] ProcessModel process)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        process.Post.CreateDate = DateTime.Now;
        //        db.Posts.Add(process.Post);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(process.Post);
        //}

        // GET: BBS/Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: BBS/Home/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: BBS/Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id); 
           
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: BBS/Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
