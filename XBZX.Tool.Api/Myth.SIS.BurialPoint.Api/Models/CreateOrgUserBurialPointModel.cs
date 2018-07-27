using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myth.SIS.BurialPoint.Api
{
    /// <summary>
    /// 创建员工端埋点的model
    /// </summary>
    public class CreateOrgUserBurialPointModel
    {
        /// <summary>
        /// 站点编码
        /// </summary>
        public string SiteCode
        {
            get; set;
        } = string.Empty;

        /// <summary>
        /// 机构Id
        /// </summary>
        public long OrgId
        {
            get; set;
        }
        /// <summary>
        /// 路由
        /// </summary>
        public string Route
        {
            get; set;
        } = string.Empty;
        /// <summary>
        /// 页面标识
        /// </summary>
        public string PageKey
        {
            get; set;
        } = string.Empty;
        /// <summary>
        /// api接口
        /// </summary>
        public string ApiInterface
        {
            get; set;
        } = string.Empty;
        /// <summary>
        /// 会话Id
        /// </summary>
        public string SessionId
        {
            get; set;
        } = string.Empty;
        /// <summary>
        /// 用户账号Id
        /// </summary>
        public long OrgUserId
        {
            get; set;
        }
        /// <summary>
        /// 客户端分辨率
        /// </summary>
        public string Resolution
        {
            get; set;
        } = string.Empty;
    }
}
