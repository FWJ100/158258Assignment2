using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace a2.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index(string search, int? page)
        {

            int pageSize = 2; // 每页显示的项数
            int pageNumber = (page ?? 1); // 当前页数，如果未提供，则默认为1

            // 创建六个人的数据
            var persons = new List<Person>
            {
                new Person { CName = "Joey Tribbiani", RealName = "Matt LeBlanc", Gender = "male", ImageUrl = "/Images/J.jpg", Else="An actor who has worked hard in the entertainment industry and loves food, he became famous as Dr. Derek Murray on Days of Our Lives.He's great at dating but not at things that require knowledge." },
                new Person { CName = "Chandler Bing", RealName = "Matthew Perry", Gender = "male", ImageUrl = "/Images/C.jpg",Else = "An executive director of the data analysis and reset department of a large multinational company. He is humorous and loves to tell jokes."},
                new Person { CName = "Ross Geller", RealName = "David Schwimmer", Gender = "male", ImageUrl = "/Images/RO.jpg",Else ="Monica's eldest brother, a bit old-fashioned, worked at the Museum of Prehistory as a paleontologist; later he worked at New York University and became a professor of paleontology." },
                new Person { CName = "Rachel Green", RealName = "Jennifer Aniston", Gender = "female", ImageUrl = "/Images/RC.jpg",Else ="Fashion enthusiast and Monica's best friend since they were teenagers. From relying on family members at the beginning, she became the main force and independent." },
                new Person { CName = "Monica Geller", RealName = "Courteney Cox", Gender = "female", ImageUrl = "/Images/M.jpg",Else ="Among the six people, he is the one who takes care of others. He is a Western chef by profession. She is well known for his perfectionism, his love of bossing others around and his competitive personality." },
                new Person { CName = "Phoebe Buffay", RealName = "Lisa Kudrow", Gender = "female", ImageUrl = "/Images/P.jpg" ,Else="She has an eccentric personality and is a masseur by profession. She taught herself guitar and composed songs. Her most famous original work is Stinky Cat."},
             };

            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                persons = persons.Where(p => p.CName.ToLower().Contains(search) ||
                                             p.RealName.ToLower().Contains(search) ||
                                             p.Gender.ToLower().Contains(search)).ToList();
            }

            // 使用PagedList对数据进行分页处理
            IPagedList<Person> pagedPersons = persons.ToPagedList(pageNumber, pageSize);

            return View(pagedPersons);


        }


    }
}