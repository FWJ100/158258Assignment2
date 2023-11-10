using a2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace a2.Controllers
{
    public class TVShowController : Controller
    {
        public ActionResult Index(int? selectedId)
        {
            // 创建模拟的电视剧数据
            var tvShows = new List<TVShow>
        {
            new TVShow { Id = 1, Name = "Season 1", ImageUrl = "/Images/image1.jpg", Description = "  The first season of \"Friends\" introduces six friends in New York City, with Rachel leaving her fiancé and moving in with Monica. Ross has a crush on Rachel, Joey dates around, Phoebe has a unique background, and Chandler reconnects with his ex-girlfriend Janice. The season ends with Rachel realizing her feelings for Ross at the airport." },
            new TVShow { Id = 2, Name = "Season 2", ImageUrl = "/Images/image2.jpg", Description = "  In the second season of \"Friends,\" Ross returns from China with a new girlfriend, Julie. Rachel struggles to confess her feelings for him, but they eventually start dating. Monica becomes a head chef but gets fired for accepting gifts. She dates Richard, a family friend, but they break up over the desire for more children. Joey gets a role on a soap opera, but his character is killed off, and he moves back in with Chandler after an odd roommate. Chandler's online chat date turns out to be his ex-girlfriend, Janice." },
            new TVShow { Id = 3, Name = "Season 3", ImageUrl = "/Images/image3.jpg", Description = "  In \"Friends\" Season 3, Chandler and Janice briefly date, while Ross and Rachel take a break leading to their breakup. Phoebe discovers her family, Joey falls in love with his co-star, and Monica dates Pete, a millionaire. The season ends with Ross having to choose between Rachel and Bonnie." },
            new TVShow { Id = 4, Name = "Season 4", ImageUrl = "/Images/image4.jpg", Description = "  In \"Friends\" Season 4, Ross and Rachel briefly reconcile but break up again due to Ross's insistence that they were on a break when he slept with someone else. Joey dates Kathy, causing tension with Chandler, but they reconcile. Phoebe loses her job as a masseuse and starts a catering business with Monica. Rachel is demoted to personal shopping and dates Joshua. Ross gets engaged to Emily in London, but during the wedding, he accidentally says Rachel's name instead of Emily's, causing chaos. Chandler and Monica sleep together." },
            new TVShow { Id = 5, Name = "Season 5", ImageUrl = "/Images/image5.jpg", Description = "  In \"Friends\" Season 4, Ross and Emily get married, but their relationship becomes strained. Rachel admits her love for Ross and dates a neighbor named Danny. Monica and Chandler keep their relationship a secret. Phoebe gives birth to triplets. Emily gives Ross an ultimatum, leading to the end of their marriage. Ross moves in with Chandler and Joey. Rachel starts a new job, and Monica and Chandler decide to get married in Las Vegas, but their plans change when they witness Ross and Rachel's drunken escapade at a wedding chapel." },
            new TVShow { Id = 6, Name = "Season 6", ImageUrl = "/Images/image6.jpg", Description = "  In \"Friends\" Season 6, Ross and Rachel's drunken marriage leads to a divorce. Monica and Chandler decide to live together and get engaged. Joey briefly dates his roommate, Janine. Ross dates a student, Elizabeth, and Rachel dates her father, Paul. Their apartment catches fire, leading to various living arrangements. Chandler plans to propose but faces obstacles, while Monica ultimately proposes to him, and they get engaged." },
            new TVShow { Id = 7, Name = "Season 7", ImageUrl = "/Images/image7.jpg", Description = "  In \"Friends\" Season 7, Monica and Chandler plan their wedding, while Joey's TV show is canceled, only to be retconned later. Phoebe's apartment is combined into one large bedroom, and Rachel moves in with Joey. Rachel promotes a young assistant, Tag, whom she eventually dates but later breaks up with on her 30th birthday. Before Monica and Chandler's wedding, Chandler panics and briefly goes into hiding. Phoebe and Rachel find a positive pregnancy test, assuming Monica is pregnant, but it's actually Rachel's." },
            new TVShow { Id = 8, Name = "Season 8", ImageUrl = "/Images/image8.jpg", Description = "  In \"Friends\" Season 8, Monica and Chandler's wedding reception leads to the discovery of Rachel's pregnancy, with Ross as the father. Rachel and Ross agree to co-parent. Joey develops romantic feelings for Rachel but learns she doesn't feel the same way. After Rachel goes into labor, Ross is encouraged to propose but hesitates, leaving a family heirloom ring in her room. Monica and Chandler decide to have a baby and start trying while at the hospital. Rachel gives birth to a baby girl, Emma. In a misunderstanding, Joey impulsively proposes to Rachel, while Ross intends to ask her about resuming their romantic relationship." },
            new TVShow { Id = 9, Name = "Season 9", ImageUrl = "/Images/image9.jpg", Description = "  In \"Friends\" Season 9, Ross and Rachel raise their daughter, Emma. Monica and Chandler face challenges in their quest to have a baby and eventually decide to adopt. Phoebe dates Mike and rejects marriage proposals from both Mike and her ex, David. Rachel returns to work, where she suspects a colleague is interested in her. Ross dates other women, and Rachel moves in with Joey. Rachel develops feelings for Joey, who initially rejects her but eventually kisses her in the season finale after Ross and Charlie kiss." },
            new TVShow { Id = 10, Name = "Season 10", ImageUrl = "/Images/image10.jpg", Description = "  In the final season of \"Friends,\" Joey and Rachel try a relationship but decide to remain friends. Charlie breaks up with Ross to reunite with her ex. Phoebe and Mike get married in an impromptu ceremony, officiated by Joey. Monica and Chandler are chosen to adopt twins from Erica. Rachel gets a job offer in Paris but eventually realizes her love for Ross. She leaves for the airport but gets off the plane to be with Ross. The series concludes with all the friends and Monica and Chandler's babies leaving their apartment together for a final cup of coffee at Central Perk, leaving behind an empty apartment." },
            // 添加其余电视剧信息
        };

            // 构建下拉菜单的选项
            ViewBag.TVShowList = new SelectList(tvShows, "Id", "Name", selectedId);

            if (!string.IsNullOrEmpty(Request.Form["restore"]))
            {
                // 如果点击了"还原"按钮，清除筛选条件
                return View(tvShows);
            }
            else
            {
                // 根据选中的编号筛选电视剧
                var selectedTVShow = tvShows.FirstOrDefault(t => t.Id == selectedId);
                return View(selectedTVShow);
            }
        }
    }

}