namespace ESoft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apartment")]
    public partial class Apartment
    {
        public int ID { get; set; }

        public int HouseID { get; set; }

        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public double Area { get; set; }

        public int CountOfRooms { get; set; }

        public int Section { get; set; }

        public int Floor { get; set; }

        public bool IsSold { get; set; }

        public int BuildingCost { get; set; }

        public int ApartmentValueAdded { get; set; }

        public bool IsDeleted { get; set; }

        public virtual House House { get; set; }
    }
}
