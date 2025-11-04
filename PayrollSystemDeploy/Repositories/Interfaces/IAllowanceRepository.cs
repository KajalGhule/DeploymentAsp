using PayrollWebApp.DTO;

namespace PayrollWebApp.Repositories.Interface
{
    public interface IAllowanceRepository
    {
        public Task<List<AllowanceDTO>> GetAllAllowances();
        public Task<int> AddAllowance(AllowanceDTO dto);
        public Task<bool> UpdateAllowance(AllowanceDTO dto);
        public Task<bool> DeleteAllowance(int id);
        public Task<AllowanceDTO?> GetAllowanceById(int id);
    }
}
