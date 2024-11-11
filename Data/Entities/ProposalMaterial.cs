using System.ComponentModel.DataAnnotations;

namespace HelloBlazorApp.Data.Entities
{
	public enum MaterialStatus : byte
	{
		Created = 0,
		Deleted = 1
	}
	public class ProposalMaterial
	{
		[Key]
		public int ID { get; set; }
		[Required]
		public MaterialStatus Status { get; set; }
		public string TextStatus => Status.ToString();
		[Required]
		public string Material_Name { get; set; }
		[Required]
		public string Material_Code { get; set; }
       
        public int Quantity { get; set; }
		[Required]
		public string? Comment { get; set; }
		[Required]
		public int ProposalId { get; set; }
	}
}