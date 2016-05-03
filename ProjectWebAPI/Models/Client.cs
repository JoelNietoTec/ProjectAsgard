namespace ProjectWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string BillName { get; set; }

        public int ClientTypeId { get; set; }

        [StringLength(50)]
        public string DocumentId { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ClientType ClientType { get; set; }
    }
}
