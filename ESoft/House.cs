namespace ESoft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("House")]
    public partial class House
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public House()
        {
            Apartment = new HashSet<Apartment>();
        }

        public int ID { get; set; }

        public int ResidentialComplexID { get; set; }

        [Required]
        [StringLength(255)]
        public string Street { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public int BuildingCost { get; set; }

        public int HouseValueAdded { get; set; }

        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apartment> Apartment { get; set; }

        public virtual ResidentialComplex ResidentialComplex { get; set; }
    }
}
