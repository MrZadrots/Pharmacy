using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Phramacy.src.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phramacy.src
{
    public class DbObjects
    {
        private static Dictionary<string, Category> category;
        public static void Initial(AppDbContent content)
        {
            if (!content.Category_Db.Any())
            {
                content.Category_Db.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Product_Db.Any())
            {
                content.AddRange(
                    new Product
                    {
                        name = "Арпефлю",
                        shortDec = "Противовирусное",
                        longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                        img = "/img/medicine/arpeflu.png",
                        price = 320,
                        IsFavourite = true,
                        available = 10,
                        Category = Categories["Лекартсвенные средства"],
                        shelf_life=new DateTime(2022,12,5)
                    },
                     new Product
                     {
                         name = "Бифиформ",
                         shortDec = "Лечение диареи",
                         longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                         img = "/img/medicine/bifi.png",
                         price = 150,
                         IsFavourite = true,
                         available = 5,
                         Category = Categories["Лекартсвенные средства"],
                         shelf_life = new DateTime(2019, 12, 5)
                     },
                     new Product
                     {
                         name = "Ксизал",
                         shortDec = "Противоаллергическое средство",
                         longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                         img = "/img/medicine/ksizal.png",
                         price = 100,
                         IsFavourite = true,
                         available = 15,
                         Category = Categories["Лекартсвенные средства"],
                         shelf_life = new DateTime(2021, 10, 5)
                     }, 
                     new Product
                     {
                         name = "Макмирор",
                         shortDec = "Противомикробное и противопротозойное средство",
                         longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                         img = "/img/medicine/makmiror.png",
                         price = 360,
                         IsFavourite = true,
                         available = 20,
                         Category = Categories["Лекартсвенные средства"],
                         shelf_life = new DateTime(2023, 11, 5)
                     },
                     new Product
                     {
                         name = "Стрепсилс",
                         shortDec = "Лечение боли в горле",
                         longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                         img = "/img/medicine/strepsils.png",
                         price = 360,
                         IsFavourite = true,
                         available = 20,
                         Category = Categories["Лекартсвенные средства"],
                         shelf_life = new DateTime(2022, 12, 5)
                     },
                      new Product
                      {
                          name = "Супрастинекс",
                          shortDec = "Противоаллергическое средство",
                          longDec = "Таблетки, покрытые оболочкой от светло-розового до розового цвета, круглые, двояковыпуклые; на поперечном разрезе видны два слоя: ядро белого цвета и оболочка от светло-розового до розового цвета.",
                          img = "/img/medicine/syprastinex.png",
                          price = 360,
                          IsFavourite = true,
                          available = 20,
                          Category = Categories["Лекартсвенные средства"],
                          shelf_life = new DateTime(2023, 12, 5)
                      },

                    new Product
                    {
                        name = "Компливит",
                        shortDec = "Витаминно-минеральный комплекс",
                        longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                        img = "/img/bads/complivit.png",
                        price = 200,
                        IsFavourite = true,
                        available = 30,
                        Category = Categories["БАДЫ"],
                        shelf_life = new DateTime(2022, 6, 5)
                    },
                    new Product
                    {
                        name = "Витамин C",
                        shortDec = "Комплекс витамина C",
                        longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                        img = "/img/bads/vitaminC.png",
                        price = 150,
                        IsFavourite = true,
                        available = 30,
                        Category = Categories["БАДЫ"],
                        shelf_life = new DateTime(2020, 12, 5)
                    }, 
                    new Product
                    {
                        name = "Витамин Д",
                        shortDec = "Комплекс витамина Д",
                        longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                        img = "/img/bads/vitaminD.png",
                        price = 150,
                        IsFavourite = true,
                        available = 30,
                        Category = Categories["БАДЫ"],
                        shelf_life = new DateTime(2021, 3, 5)
                    }, 
                    new Product
                    {
                        name = "Полисобр",
                        shortDec = "Комплекс витамина Д",
                        longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                        img = "/img/bads/polisobr.png",
                        price = 150,
                        IsFavourite = true,
                        available = 30,
                        Category = Categories["БАДЫ"],
                        shelf_life = new DateTime(2019, 6, 5)
                    },
                    new Product
                     {
                         name = "VitaWomen",
                         shortDec = "Витаминно-минеральные комплекс для женщин",
                         longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                         img = "/img/bads/VitaWomen.png",
                         price = 1197,
                         IsFavourite = true,
                         available = 7,
                         Category = Categories["БАДЫ"],
                         shelf_life = new DateTime(2024, 6, 5)
                     }, 
                    new Product
                     {
                         name = "Philip Kingsley Tricho Complex",
                         shortDec = "Витаминный комплекс для волос",
                         longDec = "Комбинированный препарат, содержащий комплекс витаминов и минералов, являющихся важными факторами метаболических процессов",
                         img = "/img/bads/PKTC.png",
                         price = 3168,
                         IsFavourite = true,
                         available = 5,
                         Category = Categories["БАДЫ"],
                         shelf_life = new DateTime(2023, 6, 5)
                     }
                    );
            }
            content.SaveChanges();
        }
        public static Dictionary<string,Category> Categories {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category{CategoryName="Лекартсвенные средства", Desc="Для лечения заболеваний"},
                        new Category{CategoryName="БАДЫ", Desc="Для профилактики заболеваний и поддержания иммунной системы"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        category.Add(element.CategoryName, element);
                    }
                }
                return category;
            }
         } 
    }
}
