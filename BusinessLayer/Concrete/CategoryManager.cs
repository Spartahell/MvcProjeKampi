using DataAccessLayer.Concrete.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category category)
        {
            if (category.CategoryName.Length<=3 || category.CategoryDescription =="" || category.CategoryName.Length>50)
            {
                //hata
            }
            else
            {
                repo.Insert(category);
            }
        }

    }
}
