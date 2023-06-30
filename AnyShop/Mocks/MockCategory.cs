using AnyShop.Interfaces;
using AnyShop.Models;

namespace AnyShop.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Автомобиль, приводимый в движение от источника электроэнергии"},
                    new Category {categoryName = "Автомобили с ДВС", desc = "Автомобиль, в котором топливная смесь сгорает внутри двигателя"}
                };
            }
        }
    }
}
