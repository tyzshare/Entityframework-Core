using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace XBZX.Training.EFCore.Service
{
    public class CreateBookDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required, MaxLength(200)]
        public string Name
        {
            get; set;
        }
        [MaxLength(1000)]
        public string Description
        { get; set; }

        public DateTime PublishDate
        {
            get; set;
        }
    }
}
