namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00103")]
    public class ItemVendorMaster
    {
        [Key]
        [Column("ITEMNMBR", Order = 0)]
        public string ItemNumber { get; set; }

        [Key]
        [Column("VENDORID", Order = 1)]
        public string VendorId { get; set; }

        [Column("ITMVNDTY")]
        public short? ItemVendorType{ get; set; }

        [Column("VNDITNUM")]
        public string VendorItemNumber { get; set; }

        [Column("QTYRQSTN")]
        public decimal? QuantityRequisitioned { get; set; }

        [Column("QTYONORD")]
        public decimal? QuantityOnOrder { get; set; }

        [Column("QTY_Drop_Shipped")]
        public decimal? QuantityDropShipped { get; set; }

        [Column("LSTORDDT")]
        public DateTime? LastOrderedDate { get; set; }

        [Column("LSORDQTY")]
        public decimal? LastOrderedQuantity { get; set; }

        [Column("LRCPTQTY")]
        public decimal? LastReceiptQuantity { get; set; }

        [Column("LSRCPTDT")]
        public decimal? LastReceiptDate { get; set; }

        [Column("LRCPTCST")]
        public decimal? LastReceiptCost { get; set; }

        [Column("AVRGLDTM")]
        public int? AverageLeadTime { get; set; }

        [Column("NORCTITM")]
        public short? NumberOfReceiptsForItem { get; set; }

        [Column("MINORQTY")]
        public decimal? MinimumOrderQuantity { get; set; }

        [Column("MAXORDQTY")]
        public decimal? MaximumOrderQuantity { get; set; }

        [Column("ECORDQTY")]
        public decimal? EcononmicOrderQuantity { get; set; }

        [Column("VNDITDSC")]
        public string VendorItemDescription { get; set; }

        [Column("Last_Originating_Cost")]
        public decimal? LastOriginatingCost { get; set; }

        [Column("Last_Currency_ID")]
        public string LastCurrencyId { get; set; }

        [Column("FREEONBOARD")]
        public short? FreeOnBoard { get; set; }

        [Column("PRCHSUOM")]
        public string PurchasingUnitOfMeasure { get; set; }

        [Column("CURRNIDX")]
        public short? CurrencyIndex { get; set; }

        [Column("PLANNINGLEADTIME")]
        public short? PlanningLeadTime { get; set; }

        [Column("ORDERMULTIPLE")]
        public decimal? OrderMultiple { get; set; }

        [Column("MNFCTRITMNMBR")]
        public string ManufactureItemNumber { get; set; }
    }
}
