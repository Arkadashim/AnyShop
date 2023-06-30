using AnyShop.Interfaces;
using AnyShop.Models;

namespace AnyShop.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla", 
                        shortDesc = "Model 3", 
                        longDesc="Двигатель - \tэлектро\r\nМощность - 321 л.с.,\r\nКоробка передач - АКПП\r\nЦвет - черный", 
                        img = "https://s1.auto.drom.ru/photo/Zal-_fhejSE0LJ9Ne1GGjj5Hzy1YKRecj4uS5X0PR3i4X4V1OGiuOJBqCNwpCkPWzYdY-TKnJLyzwYc6PljlFZxy_SC8.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        category = _categoryCars.AllCategories.First()},

                    new Car {
                        name = "Mercedes-Benz", 
                        shortDesc = "GLE Coupe", 
                        longDesc="Двигатель - Дизель, 2.9 л\r\nМощность - 330 л.с.,\r\nКоробка передач - АКПП\r\nЦвет - черный", 
                        img = "https://s1.auto.drom.ru/photo/z4sCPwv7jE2_CwvVjTmTvAWNcCCEncNIxFPjeoxTl1bOcO39pt7UNC8rpCNuOjJq2_lbyKys9ocD_-mCYl_TVI8IkjaG.jpg", 
                        price = 22000, 
                        isFavorite = false, 
                        available = true, 
                        category = _categoryCars.AllCategories.Last()},

                    new Car {
                        name = "Ford Mustang", 
                        shortDesc = "Отличается мощностью, технологиями и стилем", 
                        longDesc="Двигатель - бензин, 2.3 л\r\nМощность - 310 л.с.,\r\nКоробка передач - АКПП\r\nПривод - задний", 
                        img = "https://s1.auto.drom.ru/photo/9nbx3r1YsCXjW9GbIVwPPgNJQyFeZJRsId00Eg-QNS9eRRAqqAQLzUYbkhzd8gwrbU-k_51ag4CS-XTUR5md6gTQqjFO.jpg", 
                        price = 42000, 
                        isFavorite = false, 
                        available = false, 
                        category = _categoryCars.AllCategories.Last()},

                    new Car {
                        name = "Bentley", 
                        shortDesc = "Flying Spur", 
                        longDesc="Двигатель - бензин, 6.0 л\r\nМощность - 560 л.с.,\r\nКоробка передач - АКПП\r\nПривод - 4WD", 
                        img = "https://s1.auto.drom.ru/photo/ADioRQDcKXGwRaA-7Fp1Teg1DYLZvByleQyjuX2voIOshBeJjNnYcid4K3E86miAbxK3AoZG46Zi1sPRmmOqb1MIIvpK.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        category = _categoryCars.AllCategories.Last()},

                    new Car {
                        name = "Лада 2110", 
                        shortDesc = "Ведерко на колесиках", 
                        longDesc="Двигатель - бензин, 1.5 л\r\nМощность - 78 л.с.,\r\nКоробка передач - механика\r\nПривод - передний", 
                        img = "https://upload.wikimedia.org/wikipedia/commons/7/74/Lada_110_in_Geneva_2005.jpg", 
                        price = 1000,
                        isFavorite = false, 
                        available = false, 
                        category = _categoryCars.AllCategories.Last()},
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCars(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
