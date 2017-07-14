using aspFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspFirstApp.Repository
{
    public interface CategoryInterface
    {
         IQueryable view();
         void savaCategories(Category c);
         Category updateCategory(Category c , int id) ;
         void updatedCategory(Category c, int id);
    }
}
