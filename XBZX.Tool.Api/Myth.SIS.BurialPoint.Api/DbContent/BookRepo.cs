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
        [Key]
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
    }
}
