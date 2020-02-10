using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiBitirme.Models.Enums;

namespace WebApiBitirme.Models.Entities
{
     public abstract class BaseEntity
    { 
        public int ID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public Enums.DataStatus? Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}