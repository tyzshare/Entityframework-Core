using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myth.SIS.BurialPoint.Api.Models
{
    /// <summary>
    /// 书籍
    /// </summary>
    public class BookModel
    {
        /// <summary>
        /// Id
        /// </summary>

        public long Id
        {
            get; set;
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get; set;
        } 
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get; set;
        } 
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price
        {
            get; set;
        }
        /// <summary>
        ///发布日期
        /// </summary>
        public DateTime PublishDate
        {
            get; set;
        } 
    }
}
