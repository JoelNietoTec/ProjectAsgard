namespace ProjectWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetail
    {
        public int Id { get; set; }

        public int BillId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}
