using System.ComponentModel.DataAnnotations;

namespace HelloBlazorApp.Data.Entities
{
    public enum ProposalStatus : byte
    {
        Created = 0,
        Deleted = 1,
        Approved = 2
    }
    public class Proposal
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Proposal_num { get; set; }

        [Required]
        public DateTime Creation_date { get; set; }
        public string FullNumber
        {
            get
            {
                return $"{Creation_date:yy}/{Proposal_num:0000}";
            }
        }
        public ProposalStatus Status { get; set; }
        public string TextStatus
        {
            get
            {
                switch (Status)
                {
                    case ProposalStatus.Created:
                        return "Заявка создана";
                    case ProposalStatus.Deleted:
                        return "Заявка удалена";
                    case ProposalStatus.Approved:
                        return "Заявка утверждена";
                }
                return "";
            }
        }
        [Required]
        public string Depart { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
