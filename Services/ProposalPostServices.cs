using Microsoft.EntityFrameworkCore;

namespace HelloBlazorApp.Services
{
	public class ProposalPostServices
	{
		private readonly PurchaseContext _proposalContext;
		public ProposalPostServices(PurchaseContext proposalContext)
		{
			_proposalContext = proposalContext;
		}
		public async Task<IEnumerable<Proposal>> GetProposalAsync() =>
			await _proposalContext.Proposals
									.AsNoTracking()
									.ToListAsync();
	}
}
