using PayrollWebApp.DTO;
using PayrollWebApp.Repositories.Interface;
using PayrollWebApp.Services.Interface;

namespace PayrollWebApp.Services
{
    public class AllowanceService : IAllowanceService
    {
        private readonly IAllowanceRepository _repository;

        public AllowanceService(IAllowanceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<AllowanceDTO>> GetAllAllowances()
        {
            return await _repository.GetAllAllowances();
        }
        public async Task<bool> UpdateAllowance(AllowanceDTO dto)
        {
            return await _repository.UpdateAllowance(dto);
        }
        public async Task<bool> DeleteAllowance(int id)
        {
            return await _repository.DeleteAllowance(id);
        }
        public async Task<int> AddAllowance(AllowanceDTO dto)
        {
            return await _repository.AddAllowance(dto);
        }
        public async Task<AllowanceDTO?> GetAllowanceById(int id)
        {
            return await _repository.GetAllowanceById(id);
        }
    }
}
