using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamRent.Models
{
    public partial class Tenants
    {
        public Guid Id { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid AssetId { get; set; }
        public Guid RentalId { get; set; }
        [NotMapped]public string RentalNo { set; get; }
        [NotMapped] public string RentalName { get; set; }
        [NotMapped]public string AssetNo { get; set; }
        [NotMapped]public string AssetName { get; set; }
    }
}
