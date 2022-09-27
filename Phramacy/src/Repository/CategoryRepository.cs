using Phramacy.src.interfaces;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.Repository
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDbContent appDbContent;
        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category_Db;
    }
}
