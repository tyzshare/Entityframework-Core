using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XBZX.Training.EFCore.Repository
{
    [Table("books")]
    public class BookRepo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// Id
        /// </summary>
        public long Id
        {
            get; set;
        }
        [Required, MaxLength(200)]
        /// <summary>
        /// 书名
        /// </summary>
        public string Name
        {
            get; set;
        }
        [MaxLength(1000)]
        public string Description
        {
            get; set;
        }
        [Required]
        /// <summary>
        /// 发布日期
        /// </summary>
        public DateTime PublishDate
        {
            get; set;
        }
    }
}
