using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Myth.SIS.BurialPoint.Api.DbContent
{
    /// <summary>
    /// 书的实体模型
    /// </summary>
    public class BookRepo
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
        [Required, MaxLength(100)]
        public string Name
        {
            get; set;
        } = string.Empty;
        /// <summary>
        /// 描述
        /// </summary>
        [Required, MaxLength(100)]
        public string Description
        {
            get; set;
        } = string.Empty;
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
        } = DateTime.Now;
    }
}
