﻿namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00108")]
    public class ItemPriceList
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

        [Column("TOQTY")]
        public decimal? ToQuantity { get; set; }

        [Column("FROMQTY")]
        public decimal? FromQuantity { get; set; }

        [Column("UOMPRICE")]
        public decimal? UnitOfMeasurePrice { get; set; }

        [Column("QTYBSUOM")]
        public decimal? QuantityInBaseUnitOfMeasure { get; set; }
    }
}
