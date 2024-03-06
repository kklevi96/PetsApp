using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    public class FoodPageViewModel
    {
        public ObservableCollection<FoodType> Foods { get; set; }

        public FoodPageViewModel()
        {
            this.Foods = new ObservableCollection<FoodType>()
            {
                new FoodType()
                {
                    Name="Valami",
                    Description="Leírás",
                    Quantity=4
                },
                new FoodType()
                {
                    Name="Másik valami",
                    Description="Új leírás",
                    Quantity=3
                }
            };

        }
    }
}
