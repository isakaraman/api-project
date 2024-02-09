using api.Models;

namespace api.Interfaces
{
    public interface ICommendRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, Comment commentModel);
        Task<Comment> DeleteAsync(int id);
    }
}
