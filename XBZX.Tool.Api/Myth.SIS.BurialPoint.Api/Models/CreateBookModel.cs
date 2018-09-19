using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Myth.SIS.BurialPoint.Api.Models
{
    /// <summary>
    /// 创建书籍Model
    /// </summary>
    public class CreateBookModel
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "必填")]
        [MaxLength(100)]
        public string Name
        {
            get; set;
        }
        /// <summary>
        /// 描述
        /// </summary>
        [Required, MaxLength(1000)]
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
