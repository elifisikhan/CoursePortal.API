﻿using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Entities
{
    public class Media : BaseEntity
    {
        public string Caption { get; set; }
        public int FileSize { get; set; }
        public string FileName { get; set; }
        public MediaType MediaType { get; set; }
        public virtual ICollection<ArticleMedia> ArticleMedias { get; set; }
    }
}
