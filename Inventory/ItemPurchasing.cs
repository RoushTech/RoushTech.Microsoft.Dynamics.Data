namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00106")]
    public class ItemPurchasing
    {
        [Column("ITEMNMBR")]
        [Key]
        public string ItemNumber { get; set; }

        [Column("UOFM")]
        public string UnitOfMeasure { get; set; }

        [Column("QTYBSUOM")]
        public decimal QuantityInBaseUnitOfMeasure { get; set; }

        [Column("UMPUROPT")]
        public Int16 UnitOfMeasurePurchasesOptions { get; set; }
    }
}
