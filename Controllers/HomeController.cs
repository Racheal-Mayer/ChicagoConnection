using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Newtonsoft.Json;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get; set; }
        private PasswordHasher<User> regHasher = new PasswordHasher<User>();
        private PasswordHasher<Login> logHasher = new PasswordHasher<Login>();
        public User GetUser()
        {
            return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("userId"));
            //putting the session search in a variable that we can call throughout.
        }


        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("start")]
        public IActionResult Start()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                //seeing if the email has been used, already in the DB.
                if(_context.Users.FirstOrDefault(usr => usr.Email == newUser.Email) != null)
                {
                    ModelState.AddModelError("Email", "Email is already in use, try logging in!");
                    return View("start");
                    //land here if the email is in DB.
                }
                string hash = regHasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hash;
                //hashing password
                _context.Users.Add(newUser);
                _context.SaveChanges();
                //saving to database
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                //adding the new user into session to be userId
                return Redirect ("/home");
                }
            return View("start");
            //if validations aren't met.
        }
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View("AdminAdd");
        }

        [HttpPost("AdminAdd")]
        public IActionResult AdminAdd(User newUser)
        {
            if(ModelState.IsValid)
            {
                //seeing if the email has been used, already in the DB.
                if(_context.Users.FirstOrDefault(usr => usr.Email == newUser.Email) != null)
                {
                    ModelState.AddModelError("Email", "Email is already in use, try logging in!");
                    return View("AdminAdd");
                    //land here if the email is in DB.
                }
                string hash = regHasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hash;
                //hashing password
                _context.Users.Add(newUser);
                _context.SaveChanges();
                //saving to database
                HttpContext.Session.SetInt32("userId", newUser.UserId);
                //adding the new user into session to be userId
                return Redirect("/Admin/Manage");
                }
            return View("AdminAdd");
            //if validations aren't met.
        }

        [HttpPost("login")]
        public IActionResult Login(Login lu)
        {
            if(ModelState.IsValid)
            //if validations are met
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == lu.LoginEmail);
                //comparing the logged in email(lu) w/ a user in the DB.
                if(userInDb == null)
                //check if user is in DB.
                //if it is not in DB
                {
                    ModelState.AddModelError("LoginEmail", "Email not in database.");
                    return View("start");
                }
                var result = logHasher.VerifyHashedPassword(lu, userInDb.Password, lu.LoginPassword);
                //comparing hashed password in DB against hashed password from logging in user
                if(result == 0)
                //if there is an error
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email or Password!");
                    return View("start");
                }
                HttpContext.Session.SetInt32("userId", userInDb.UserId);
                //logging user in by setting in session
                return Redirect("/home");
            }
            return View("start");
            //landed if validations aren't met.
        }
        [HttpGet("Admin/Manage")]
        public IActionResult AdminManage(int userId)
        {
            List<User> Allusers = _context.Users
                                    .ToList();
            ViewBag.User  = _context.Users;
            return View("AdminManage", Allusers);
        }

        [HttpGet("Admin/edit/{userId}")]
        public IActionResult AdminEdit(int userId)
        {
            User UsertoEdit = _context.Users
            .FirstOrDefault(User => User.UserId == userId);
            return View("AdminEdit", UsertoEdit);
        }

        [HttpPost("Admin/update/{UserId}")]
        public IActionResult AdminUpdate(int userId, User Updated)
        {
            if(ModelState.IsValid)
            {
                User UsertoEdit = _context.Users
                .FirstOrDefault(User => User.UserId == userId);
                UsertoEdit.Email = Updated.Email;
                UsertoEdit.FirstName = Updated.FirstName;
                UsertoEdit.LastName = Updated.LastName;
                UsertoEdit.Password = Updated.Password;
                UsertoEdit.Description = Updated.Description;
                UsertoEdit.Admin = Updated.Admin;
                UsertoEdit.UpdatedAt= DateTime.Now;
                string hash = regHasher.HashPassword(UsertoEdit, UsertoEdit.Password);
                UsertoEdit.Password = hash;
                _context.SaveChanges();
                return Redirect("/Admin/Manage");
            }
            else
            {
                Updated.UserId = userId;
                return View("/Admin/Manage");
            }
        }

        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            User toDelete = _context.Users
                .FirstOrDefault( m => m.UserId == userId);
                _context.Users.Remove(toDelete);
                int? UserId = HttpContext.Session.GetInt32 ("UserId");
                _context.SaveChanges();
                return Redirect("/Admin/Manage");
        }
        
        [HttpGet("Wall")]
        public IActionResult Wall(int UserId)
        {
            var userId = _context.Users.FirstOrDefault(u=> u.UserId == (int?)HttpContext.Session.GetInt32("userId"));
            if(userId == null)
            //checking to see if there is a user logged into session (logged in)
            //if not, redirect.
            {
                return Redirect("/");
            }
            List<Message> Messages = _context.Messages
                        .Include(m => m.Creator)
                        .Include(m => m.Comments)
                        .ThenInclude(c => c.Writer)
                        //diff table, diff variable.
                        .OrderByDescending(m => m.CreatedAt)
                        .ToList();
            ViewBag.Messages = Messages;
            List<Comment> Comments = _context.Comments
                        .Include(m => m.Maker)
                        .OrderBy(m => m.CreatedAt)
                        .ToList();
            ViewBag.Comments = Comments;
            ViewBag.User = userId;
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=us&" +
            "apiKey=da7199465e0043378f62c646fdb390ad";
            var json = new WebClient().DownloadString(url);
            var result = JsonConvert.DeserializeObject<NewsResult>(json);
            ViewBag.News = result;
            Console.WriteLine(json);
            return View();
        }
        
        [HttpGet("Deets")]
        public IActionResult Deets()
        {
            var userInDb = _context.Users.FirstOrDefault(u=> u.UserId == (int)HttpContext.Session.GetInt32("userId"));
            if(userInDb == null)
            {
                return View("Index");
            }
            ViewBag.User = userInDb;
            List<User> Allusers = _context.Users
                .ToList();
            return View("Deets", Allusers);
        }
        [HttpGet("MeetUp")]
        public IActionResult MeetUp()
        {
            User current = GetUser();
            //setting variable of current to current user in DB from the GetUser Function
            if(current == null)
            //checking to see if there is a user logged into session (logged in)
            //if not, redirect.
            {
                return Redirect("/");
            }
            List<MeetUp> AllActivities = _context.Activities
                            .Include(m => m.Coordinator)
                            .Include(m => m.Participants)
                            .ThenInclude(wp => wp.Tagalong)
                            .Where(m => m.Date >= DateTime.Now)
                            .OrderBy(m => m.Date)
                            .ToList();
            ViewBag.User = current;
            var cta = "http://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?" + "key=820a1838a4fc456f92524744c306df76&mapid=40380&outputType=JSON";
            var ctajson = new WebClient().DownloadString(cta);
            var ctaresult = JsonConvert.DeserializeObject<wrapper>(ctajson);
            ViewBag.cta = ctaresult;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine(ctajson);
            return View("MeetUp", AllActivities);
        }
        [HttpPost("search")]
        public IActionResult Search(string q)
        {
            var userId = _context.Users.FirstOrDefault(u=> u.UserId == (int?)HttpContext.Session.GetInt32("userId"));
            if(userId == null)
            //checking to see if there is a user logged into session (logged in)
            //if not, redirect.
            {
                return Redirect("/");
            }
            List<MeetUp> SearchResults = _context.Activities
                            .Include(m => m.Coordinator)
                            .Include(m => m.Participants)
                            .ThenInclude(wp => wp.Tagalong)
                            .Where(m => m.Date >= DateTime.Now)
                            .OrderBy(m => m.Date)
                            .Where(
                            m => m.Title.Contains(q) || m.Description.Contains(q) || m.Coordinator.FirstName.Contains(q)
                        )
                        .ToList();
            ViewBag.User = userId;
            var cta = "http://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?" + "key=820a1838a4fc456f92524744c306df76&mapid=40380&outputType=JSON";
            var ctajson = new WebClient().DownloadString(cta);
            var ctaresult = JsonConvert.DeserializeObject<wrapper>(ctajson);
            ViewBag.cta = ctaresult;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine(ctajson);
            return View("MeetUp", SearchResults);
        }

        [HttpGet("activity/{meetupId}/status")]
        public IActionResult ToggleActivity(int meetupId, string status)
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
            }
            if(status == "join")
            {
                Association newAct = new Association();
                newAct.UserId = current.UserId;
                newAct.MeetUpId = meetupId;
                //making the join
                _context.Associations.Add(newAct);
                //creating a new watchparty which means association
            }
            else if(status == "leave")
            {
                Association backout = _context.Associations
                                    .FirstOrDefault(w => w.UserId == current.UserId && w.MeetUpId == meetupId);
                                    _context.Associations.Remove(backout);
                                    //we need the & statement to detect movie ID.
                                    //making sure they are equal.
            }
            _context.SaveChanges();
            return RedirectToAction("MeetUp");
            }

            [HttpGet("activity/{meetupId}")]
            public IActionResult DisplayActivity(int meetupId)
            {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
                //checking the ID 
            }
            MeetUp showing = _context.Activities
                            .Include(m => m.Participants)
                            .ThenInclude(u => u.Tagalong)
                            .Include(m => m.Coordinator)
                            .FirstOrDefault(m => m.MeetUpId == meetupId);
                            //grab the activity that matches the route
            ViewBag.User = current;
            return View(showing);
            }

        [HttpGet("activity/{meetupId}/delete")]
        public IActionResult DeleteActivity(int meetupId)
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
                //checking the ID 
            }
            MeetUp remove = _context.Activities.FirstOrDefault(m => m.MeetUpId == meetupId);
            _context.Activities.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction("MeetUp");
        }

        [HttpGet("activity/new")]
        public IActionResult NewActivity()
        { 
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
            }
            ViewBag.User = current;
            return View("NewActivity");
        }
        
        [HttpPost("activity/create")]
        public IActionResult CreateMovie(MeetUp newActivity)
        {
            User current = GetUser();
            if(current == null)
            {
                return Redirect("/");
                //checking the ID 
            }
            if(ModelState.IsValid)
            {
                newActivity.UserId = current.UserId;
                //putting the id of the person logged in, into the id of the new movie being created
                _context.Activities.Add(newActivity);
                _context.SaveChanges();
                return RedirectToAction("MeetUp");
            }
            return View("NewActivity");
        }


        [HttpPost("/message")]
        public IActionResult Message(Message newMessage, int messageId)
        {
            //get info from form
            // store into database with userId
            //save
            int? userId = HttpContext.Session.GetInt32("userId");
            newMessage.UserId = (int)userId;
            _context.Messages.Add(newMessage);
            _context.SaveChanges();
            List<Message> Messages = _context.Messages
                        .Include(m => m.Creator)
                        .Include(m => m.Comments)
                        .ThenInclude( c => c.Writer)
                        .OrderBy(m => m.CreatedAt)
                        .ToList();
            ViewBag.Messages = Messages;
            User userInDb = _context.Users
                .FirstOrDefault(o => o.UserId == userId);
            ViewBag.User = userInDb;
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=us&" +
            "apiKey=da7199465e0043378f62c646fdb390ad";
            var json = new WebClient().DownloadString(url);
            var result = JsonConvert.DeserializeObject<NewsResult>(json);
            ViewBag.News = result;
            return View("wall");
        }

        [HttpPost("/comment")]
        public IActionResult Comment(Comment newComment, int commentId, int messageId)
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            newComment.UserId = (int)userId;
            _context.Comments.Add(newComment);
            _context.SaveChanges();
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=us&" +
            "apiKey=da7199465e0043378f62c646fdb390ad";
            var json = new WebClient().DownloadString(url);
            var result = JsonConvert.DeserializeObject<NewsResult>(json);
            ViewBag.News = result;
            return Redirect("/Wall");
        }
        [HttpGet("/delete/{messageId}/message")]
        public IActionResult DeletePost(int messageId)
        {
            Message toDelete = _context.Messages
                .FirstOrDefault( m => m.MessageId == messageId);
                _context.Messages.Remove(toDelete);
                int? userId = HttpContext.Session.GetInt32 ("UserId");
                _context.SaveChanges();
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=us&" +
            "apiKey=da7199465e0043378f62c646fdb390ad";
            var json = new WebClient().DownloadString(url);
            var result = JsonConvert.DeserializeObject<NewsResult>(json);
            ViewBag.News = result;
                return Redirect("/Wall");
        }

        
        [HttpGet("/delete/{commentId}/comment")]
        public IActionResult DeleteComment(int commentId)
        {
            Comment toDelete = _context.Comments
                .FirstOrDefault( m => m.CommentId == commentId);
                _context.Comments.Remove(toDelete);
                int? userId = HttpContext.Session.GetInt32 ("UserId");
                _context.SaveChanges();
            var url = "http://newsapi.org/v2/top-headlines?" +
            "country=us&" +
            "apiKey=da7199465e0043378f62c646fdb390ad";
            var json = new WebClient().DownloadString(url);
            var result = JsonConvert.DeserializeObject<NewsResult>(json);
            ViewBag.News = result;
                return Redirect("/Wall");
        }

        [HttpGet("home")]
        public IActionResult Dash (int userId)
        {
            var userInDb = _context.Users.FirstOrDefault(u=> u.UserId == (int)HttpContext.Session.GetInt32("userId"));
            if(userInDb == null)
            // query for checking if someone is logged in.
            {
                return View("Index");
            }
            ViewBag.User = userInDb;
            List<User> Allusers = _context.Users
                .ToList();
                return View("home", Allusers);
        }
        [HttpGet("show/{userId}")]
        public IActionResult ShowUser (int userId)
        {
            User toDisplay = _context.Users
                    .Include(w => w.MyJoins)
                    .ThenInclude(w => w.Joined)
                    .Include(u => u.PlannedActivities)
                    .FirstOrDefault( w => w.UserId == userId);
            ViewBag.toDisplay = toDisplay;
            return View("Display", toDisplay);
        }

        [HttpGet("edit/{userId}")]
        public IActionResult EditUser(int userId)
        {
            User UsertoEdit = _context.Users
            .FirstOrDefault(User => User.UserId == userId);
            return View("Edit", UsertoEdit);
        }

        [HttpPost("update/{UserId}")]
        public IActionResult Updateuser(int userId, User Updated)
        {
            if(ModelState.IsValid)
            {
                User UsertoEdit = _context.Users
                .FirstOrDefault(User => User.UserId == userId);
                UsertoEdit.Email = Updated.Email;
                UsertoEdit.FirstName = Updated.FirstName;
                UsertoEdit.LastName = Updated.LastName;
                UsertoEdit.Password = Updated.Password;
                UsertoEdit.Description = Updated.Description;
                UsertoEdit.Admin = Updated.Admin;
                UsertoEdit.UpdatedAt= DateTime.Now;
                UsertoEdit.ImgUrl= Updated.ImgUrl;
                UsertoEdit.Handle= Updated.Handle;
                UsertoEdit.Industry= Updated.Industry;
                string hash = regHasher.HashPassword(UsertoEdit, UsertoEdit.Password);
                UsertoEdit.Password = hash;
                _context.SaveChanges();
                return Redirect("/Deets");
            }
            else
            {
                Updated.UserId = userId;
                return View("edit", Updated);
            }
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect ("/");
        }
    }
}
