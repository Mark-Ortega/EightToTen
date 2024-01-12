
namespace EightToTen.Services.ResturantPicker;
    public class ResturantPickerServices : IResturantPickerServices
    {
        public string PickResturant(string mexicanChineseFastfood)
        {
            if(mexicanChineseFastfood.ToLower() == "mexican")
            {
            string[] mexicanPlace = 
            {
            "Aceituno's Mexican food spanaway",
            "El Ranchito",
            "La Baja",
            "Nena's Mexican Cuisine",
            "El Grullito",
            "La Mesa",
            "Tequileros Taqueria",
            "Don Luis Mexican Restuarant",
            "El Chilango Chido",
            "Casa Flores"
            };
            Random mexicanChoice = new Random();
            var mexicanPlaceChoice = mexicanChoice.Next(0, mexicanPlace.Length);
            return $"Go to {mexicanPlace[mexicanPlaceChoice]}";
            
            }
            else if(mexicanChineseFastfood.ToLower() == "chinese")
            {
                string[] chinesePlace = 
            {
            "Louie's Chinese Restaurant",
            "Saigon Bowl Noodle House",
            "The Chopstick",
            "Forum Dynasty",
            "Yen Du Restaurant",
            "Peking restaurant",
            "Tsing Tao",
            "New Yen Ching Restaurant",
            "Dave Wongs",
            "Shermans Buffet"
            };
            Random chineseChoice = new Random();
            var chinesePlaceChoice = chineseChoice.Next(0, chinesePlace.Length);
            return $"Go to {chinesePlace[chinesePlaceChoice]}";
            }
            else if (mexicanChineseFastfood.ToLower() == "fastfood")
            {
                string[] fastfoodPlace = 
            {
            "Mcdonalds",
            "Jack in the Box",
            "Carls Jr.",
            "Sonics",
            "Taco Bell",
            "Wendy's",
            "Burger King",
            "Church's Chicken",
            "El Pollo Loco",
            "Raising Canes"
            };
            Random fastfoodChoice = new Random();
            var fastfoodPlaceChoice = fastfoodChoice.Next(0, fastfoodPlace.Length);
            return $"Go to {fastfoodPlace[fastfoodPlaceChoice]}";
            }
            else
            {
                return "Please type mexican, chinese, or fastfood";
            }
            
        }
    }
