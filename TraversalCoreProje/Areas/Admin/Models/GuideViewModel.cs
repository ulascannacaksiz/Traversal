namespace TraversalCoreProje.Areas.Admin.Models
{
    public partial class GuideViewModel
    {
        public int GuideId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }

        public string EncryptedId { get; set; }
    }
}
