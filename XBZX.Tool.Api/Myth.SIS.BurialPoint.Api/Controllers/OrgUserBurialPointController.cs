using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Myth.SIS.BurialPoint.Api.Controllers
{
    /// <summary>
    /// 员工端埋点
    /// </summary>
    //[Produces("application/json")]
    [Route("api/OrgUserBurialPoint")]
    public class OrgUserBurialPointController : Controller
    {
        private MyContext Context;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_context"></param>
        public OrgUserBurialPointController(MyContext _context)
        {
            Context = _context;
        }

        /// <summary>
        /// 简单查询
        /// </summary>
        /// <returns></returns>
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "hello world", "数据埋点" };
        }

        /// <summary>
        /// 创建员工端埋点信息
        /// </summary>
        /// <param name="model">创建员工端埋点信息model</param>
        // POST api/<controller>
        [HttpPost]
        public async Task Post([FromBody]CreateOrgUserBurialPointModel model)
        {
            //获取客户端ip地址
            string userHostAddress = HttpContext.GetUserIp();
            //获取客户端信息
            string userAgent = HttpContext.Request.Headers["user-agent"];
            Context.OrgUserBurialPointRepos.Add(new OrgUserBurialPointRepo()
            {
                SiteCode = model.SiteCode,
                OrgId = model.OrgId,
                IP = userHostAddress,
                ApiInterface = model.ApiInterface,
                OrgUserId = model.OrgUserId,
                PageKey = model.PageKey,
                Resolution = model.Resolution,
                Route = model.Route,
                SessionId = model.SessionId,
                UserAgent = userAgent ?? string.Empty,
                CreateAt = DateTime.Now
            });
            await Context.SaveChangesAsync();
        }
    }
}
