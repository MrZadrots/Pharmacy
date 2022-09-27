using Phramacy.src.interfaces;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src.mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName="Лекартсвенные средства", Desc="Для лечения заболеваний"},
                    new Category{CategoryName="БАДЫ", Desc="Для профилактики заболеваний и поддержания иммунной системы"}
                };
            }
        }
    }
}
