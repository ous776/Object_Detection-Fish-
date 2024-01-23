using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GamRent.Model
{
    [TypeDescriptionProvider(typeof(MetadataTypeAttribute))]
    public partial class Rental
    {
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string RentNo { get; set; } = string.Empty;
        [Display(Name ="Deposit")]
        public double AdvanceDeposit { get; set; }
        public Guid AssetId { get; set; }
        public string AssetNo { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsOccupaid { get; set; }=false;
        [Display(Name = "Start Date")]
        public DateTime ContractStartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime ContractEndDate { get; set; }
        public DateTime LastContractRenewDate { get; set; }
        [Display(Name = "Amount Paid")]
        public double LastPaymentAmount { get; set; }
        [Display(Name = "Pending Balance")]
        public double PendingBalance { get; set; } = 0.0;
        [Display(Name = "Next Payment")]
        public DateTime NextPaymentDate {  get; set; }
        [Display(Name = "Last Payment")]
        public DateTime LastPaymentDate { get; set; }
        //public double MonthlyCost { get; set; }=double.MaxValue;
        //public double DaylyCost { get; set;}=double.MaxValue;
        public double Cost { get; set; } = double.MaxValue;
    }
}
