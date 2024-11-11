using Microsoft.EntityFrameworkCore;

namespace HelloBlazorApp.Services
{
	public class MaterialPostServices
	{
		private readonly PurchaseContext _proposalMaterialContext;
		public MaterialPostServices(PurchaseContext proposalMaterialContext) 
		{
			_proposalMaterialContext = proposalMaterialContext;
		}

		public async Task<IEnumerable<ProposalMaterial>> GetProposalMaterialsAsync() =>
			await _proposalMaterialContext.ProposalMaterials
										   .AsNoTracking()
											.ToListAsync();
		public async Task<ProposalMaterialSaveModel?> GetProposalMaterialAsync(int proposalMaterialId) =>
			await _proposalMaterialContext.ProposalMaterials
											.Select(ProposalMaterialSaveModel.Selector)
										   .AsNoTracking()
											.FirstOrDefaultAsync(bp=>bp.ID== proposalMaterialId);
		public async Task SaveAsync(ProposalMaterialSaveModel proposalMaterial)
		{
			var entity = proposalMaterial.ToProposalMaterialEntity();
			if (entity.ID == 0)
			{
				// Добавление нового материала
				

				await _proposalMaterialContext.AddAsync(entity);
			}
			else
			{
				//Редактирование материала
				entity = proposalMaterial.Merge(await _proposalMaterialContext.ProposalMaterials.FirstOrDefaultAsync(bp => bp.ID == proposalMaterial.ID));

			}
		}
	}
}
