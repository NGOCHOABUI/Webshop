using System;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        [MaxLength(256)]
        public DateTime? UpdateDate { set; get; }

        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}
