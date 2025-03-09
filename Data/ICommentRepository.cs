using System.Collections.Generic;
using System.Threading.Tasks;
using BTL_NMCNPM.Models;

namespace BTL_NMCNPM.Data{
    public interface ICommentRepository{
        Task<List<Comment>> GetComments();
        Task<bool> AddComment(Comment comment);
    }
}