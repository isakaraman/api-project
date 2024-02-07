using api.Models;

namespace api.Interfaces
{
    public interface ICommendRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
    }
}
