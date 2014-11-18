namespace RoushTech.Microsoft.Dynamics.Import.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00105")]
    public class ItemCurrencyMaster
    {
        [Column("ITEMNMBR")]
        [StringLength(30)]
        public string ItemNumber { get; set; }

        [Column("CURNCYID")]
        [StringLength(15)]
        public string CurrencyId { get; set; }

        [Column("CURRNIDX")]
        public Int16 CurrencyIndex { get; set; }

        [Column("DECPLCUR")]
        public Int16 DecimalPlacesInCurrency { get; set; }

        [Column("LISTPRCE")]
        public decimal ListPrice { get; set; }
    }
}
