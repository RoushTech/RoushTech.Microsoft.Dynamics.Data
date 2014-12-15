namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00105")]
    public class ItemCurrencyMaster
    {
        [Key]
        [Column("ITEMNMBR")]
        public string ItemNumber { get; set; }

        [Column("CURNCYID")]
        public string CurrencyId { get; set; }

        [Column("CURRNIDX")]
        public short? CurrencyIndex { get; set; }

        [Column("DECPLCUR")]
        public short? DecimalPlacesInCurrency { get; set; }

        [Column("LISTPRCE")]
        public decimal? ListPrice { get; set; }
    }
}
