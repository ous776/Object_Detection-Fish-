using System;

namespace GamRent.Model
{
    public partial class Maintenance
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public string AssetNo { get; set; }
        public string RentNo { get; set; }
        public DateTime DateReported { get; set; } = DateTime.Now;
        public DateTime ?FixDate {  get; set; } 
        public DateTime CreatedDate { get; set;}=DateTime.Now;
        public DateTime UpdatedDate { get; set;} = DateTime.Now;
        public double Cost { get; set; }
        public bool IsCompleted { get; set; }=false;
    }
}
