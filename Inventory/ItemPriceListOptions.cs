namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00107")]
    public class ItemPriceListOptions
    {
        [Column("ITEMNMBR")]
        [StringLength(30)]
        public string ItemNumber { get; set; }

        [Column("CURNCYID")]
        [StringLength(15)]
        public string CurrencyId { get; set; }

        [Column("PRCLEVEL")]
        [StringLength(10)]
        public string PriceLevel { get; set; }

        [Column("UOFM")]
        [StringLength(8)]
        public string UnitOfMeasure { get; set; }

        [Column("RNDGAMNT")]
        public decimal RoundingAmount { get; set; }

        [Column("ROUNDHOW")]
        public Int16 RoundHow { get; set; }

        [Column("ROUNDTO")]
        public Int16 RoundTo { get; set; }

        [Column("UMSLSOPT")]
        public Int16 UnitOfMeasureSalesOptions { get; set; }

        [Column("QTYBSUOM")]
        public decimal QuantityInBaseUnitOfMeasure { get; set; }
    }
}
