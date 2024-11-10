using System.ComponentModel.DataAnnotations;

namespace HelloBlazorApp.Services
{
    public enum MaterialStatus : byte
    {
        Created = 0,
        Deleted = 1
    }
    public class ProposalMaterial
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public MaterialStatus Status { get; set; }
        public string TextStatus => Status.ToString();
        [Required]
        public string Material_Name { get; set; }
        [Required]
        public string Material_Code { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Comment { get; set; }
        [Required]
        public int ProposalId { get; set; }
    }
}
