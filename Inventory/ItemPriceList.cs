namespace RoushTech.Microsoft.Dynamics.Import.Data.Inventory
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00108")]
    public class ItemPriceList
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

        [Column("TOQTY")]
        public decimal ToQuantity { get; set; }

        [Column("FROMQTY")]
        public decimal FromQuantity { get; set; }

        [Column("UOFMPRICE")]
        public decimal UnitOfMeasurePrice { get; set; }

        [Column("QTYBSUOM")]
        public decimal QuantityInBaseUnitOfMeasure { get; set; }
    }
}
