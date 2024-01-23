namespace GamRent.Model
{
    public partial class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; }=string.Empty;
        public string Location { get; set; } = string.Empty;
        public string AssetNo { get; set; } = string.Empty;
        public string RentalNo { get; set; } = string.Empty;
    }
}
