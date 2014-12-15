namespace RoushTech.Microsoft.Dynamics.Data.Inventory
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("IV00101")]
    public class ItemMaster
    {
        [Key]
        [Column("ITEMNMBR")]
        public string ItemNumber { get; set; }

        [Column("ITEMDESC")]
        public string ItemDescription { get; set; }

        [Column("NOTEINDX")]
        public decimal? NoteIndex { get; set; }

        [Column("ITMSHNAM")]
        public string ItemShortName { get; set; }

        [Column("ITEMTYPE")]
        public short? ItemType { get; set; }

        [Column("ITMGEDSC")]
        public string ItemGenericDescription { get; set; }

        [Column("STNDCOST")]
        public decimal? StandardCost { get; set; }

        [Column("CURRCOST")]
        public decimal? CurrentCost { get; set; }

        [Column("ITEMSHWT")]
        public int? ItemShippingWeight { get; set; }

        [Column("DECPLQTY")]
        public short? DecimalPlacesQuantities { get; set; }

        [Column("DECPLCUR")]
        public short? DecimalPlacesCurrency { get; set; }

        [Column("ITMTSHID")]
        public string ItemTaxScheduleId { get; set; }

        [Column("TAXOPTNS")]
        public short? TaxOptions { get; set; }

        [Column("IVIVINDX")]
        public int? IvIvIndex { get; set; }

        [Column("IVIVOFIX")]
        public int? IvIvOffsetIndex { get; set; }

        [Column("IVCOGSIX")]
        public int? IvSalesIndex { get; set; }

        [Column("IVSLDSIX")]
        public int? IvSalesDiscountsIndex { get; set; }

        [Column("IVSLRNIX")]
        public int? IvSalesReturnsIndex { get; set; }

        [Column("IVINUSIX")]
        public int? IvInUseIndex { get; set; }

        [Column("IVINSVIX")]
        public int? IvInServiceIndex { get; set; }

        [Column("IVDMGIDX")]
        public int? IvDamagedIndex { get; set; }
        
        [Column("IVVARIDX")]
        public int? IvVariancesIndex { get; set; }

        [Column("DPSHPIDX")]
        public int? DropShipIndex { get; set; }

        [Column("PURPVIDX")]
        public int? PurchasePriceVarianceIndex { get; set; }

        [Column("UPPVIDX")]
        public int? UnrealizedPurchasePriceVarianceIndex { get; set; }

        [Column("IVRETIDX")]
        public int? InventoryReturnsIndex { get; set; }

        [Column("ASMVRIDX")]
        public int? AssemblyVarianceIndex { get; set; }

        [Column("ITMCLSCD")]
        public string ItemClassCode { get; set; }

        [Column("ITMTRKOP")]
        public short? ItemTrackingOption { get; set; }

        [Column("LOTTYPE")]
        public string LotType { get; set; }

        [Column("KPERHIST")]
        public byte? KeepPeriodHistory { get; set; }

        [Column("KPTRXHST")]
        public byte? KeepTrxHistory { get; set; }

        [Column("KPCALHST")]
        public byte? KeepCalendarHistory { get; set; }

        [Column("KPDSTHST")]
        public byte? KeepDistributionHistory { get; set; }

        [Column("ALWBKORD")]
        public byte? AllowBackOrders { get; set; }

        [Column("VCTNMTHD")]
        public short? ValuationMethod { get; set; }

        [Column("UOMSCHDL")]
        public string UnitOfMeasureSchedule { get; set; }

        [Column("ALTITEM1")]
        public string AlternateItem1 { get; set; }

        [Column("ALTITEM2")]
        public string AlternateItem2 { get; set; }

        [Column("USCATVLS_1")]
        public string UserCategoryValues1 { get; set; }

        [Column("USCATVLS_2")]
        public string UserCategoryValues2 { get; set; }

        [Column("USCATVLS_3")]
        public string UserCategoryValues3 { get; set; }

        [Column("USCATVLS_4")]
        public string UserCategoryValues4 { get; set; }

        [Column("USCATVLS_5")]
        public string UserCategoryValues5 { get; set; }

        [Column("USCATVLS_6")]
        public string UserCategoryValues6 { get; set; }

        [Column("MSTRCDTY")]
        public short? MasterRecordType { get; set; }

        [Column("MODIFDT")]
        public DateTime? ModifiedDate { get; set; }

        [Column("CREATDDT")]
        public DateTime? CreatedDate { get; set; }

        [Column("WRNTYDYS")]
        public short? WarrantyDays { get; set; }

        [Column("PRCLEVEL")]
        public string PriceLevel { get; set; }

        [Column("LOCNCODE")]
        public string LocationCode { get; set; }

        [Column("PINFLIDX")]
        public int? PurchInflationIndex { get; set; }

        [Column("PURMCIDX")]
        public int? PurchMonetaryCorrectionIndex { get; set; }

        [Column("IVINFIDX")]
        public int? InventoryInflationIndex { get; set; }

        [Column("INVMCIDX")]
        public int? InventoryMonetaryCorrectionIndex { get; set; }

        [Column("CGSINFLX")]
        public int? COGSInflationIndex { get; set; }

        [Column("CGSMCIDX")]
        public int? COGSMonetaryCorrectionIndex { get; set; }

        [Column("ITEMCODE")]
        public string ItemCode { get; set; }

        [Column("TCC")]
        public string TaxCommodityCode { get; set; }

        [Column("PriceGroup")]
        public string PriceGroup { get; set; }

        [Column("PRICMTHD")]
        public short? PriceMethod { get; set; }

        [Column("PRCHSUOM")]
        public string PurchasingUnitOfMeasure { get; set; }

        [Column("SELNGUOM")]
        public string SellingUnitOfMeasure { get; set; }

        [Column("KTACCTSR")]
        public short? KitCOGSAccountSource { get; set; }

        [Column("LASTGENSN")]
        public string LastGeneratedSerialNumber { get; set; }

        [Column("ABCCODE")]
        public short? ABCCode { get; set; }

        [Column("Revalue_Inventory")]
        public byte? RevalueInventory { get; set; }

        [Column("Tolerance_Percentage")]
        public int? TolerancePercentage { get; set; }

        [Column("Purchase_Item_Tax_Schedu")]
        public string PurchaseItemTaxScheduleId { get; set; }

        [Column("Purchase_Tax_Options")]
        public short? PurchaseTaxOptions { get; set; }

        [Column("ITMPLNNNGTYP")]
        public short? ItemPlanningType { get; set; }

        [Column("STTSTCLVLPRCNTG")]
        public short? StatisticalValuePercentage { get; set; }

        [Column("CNTRYORGN")]
        public string CountryOrigin { get; set; }

        [Column("INACTIVE")]
        public byte? Inactive { get; set; }

        [Column("MINSHELF1")]
        public short? MinShelfLife1 { get; set; }

        [Column("MINSHELF2")]
        public short? MinShelfLife2 { get; set; }

        [Column("INCLUDEINDP")]
        public byte? IncludeInDemandPlanning { get; set; }

        [Column("LOTEXPWARN")]
        public byte? LotExpireWarning { get; set; }

        [Column("LOTEXPWARNDAYS")]
        public short? LotExpireWarningDays{ get; set; }

        [Column("LASTGENLOT")]
        public string LastGeneratedLotNumber { get; set; }

        [Column("Lot_Split_Quantity")]
        public decimal? LotSplitQuantity { get; set; }
    }
}
