namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00107")]
    public class ItemPriceListOptions
    {
        [Column("ITEMNMBR")]
        [Key]
        public string ItemNumber { get; set; }

        [Column("CURNCYID")]
        public string CurrencyId { get; set; }

        [Column("PRCLEVEL")]
        public string PriceLevel { get; set; }

        [Column("UOFM")]
        public string UnitOfMeasure { get; set; }

        [Column("RNDGAMNT")]
        public decimal? RoundingAmount { get; set; }

        [Column("ROUNDHOW")]
        public short? RoundHow { get; set; }

        [Column("ROUNDTO")]
        public short? RoundTo { get; set; }

        [Column("UMSLSOPT")]
        public short? UnitOfMeasureSalesOptions { get; set; }

        [Column("QTYBSUOM")]
        public decimal? QuantityInBaseUnitOfMeasure { get; set; }
    }
}
