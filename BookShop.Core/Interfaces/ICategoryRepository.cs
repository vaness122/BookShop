using BookShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Core.Interfaces
{
    public interface ICategoryRepository
    {
       Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task AddAsync(Category category);
        Task DeleteAsync(int id);
        Task UpdateAsync(Category category);

        
    }
}
