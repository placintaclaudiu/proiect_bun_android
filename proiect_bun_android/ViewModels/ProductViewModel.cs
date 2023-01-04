using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using proiect_bun_android.Models;
using proiect_bun_android.Views;

namespace proiect_bun_android.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<Items> Items { get; set; }
        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }
        public ICommand CartItemclick { get; set; }

       // private INavigation navigation;

        public ProductViewModel(INavigation navigation) {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Picture="golan.jpg",
                    Name = "Dacia Logan",
                    An = "2005",
                    Price = "1250 euro"
                },
                new Items
                {
                    Picture="stepway.jpg",
                    Name = "Dacia Sandero Stepway",
                    An = "2020",
                    Price = "7000 euro"
                },
                new Items
                {
                    Picture="x3.jpg",
                    Name = "BMW X3",
                    An = "2019",
                    Price = "18000 euro"
                },
                new Items
                {
                    Picture="vwpolo.jpg",
                    Name = "VW Polo",
                    An = "2016",
                    Price = "3250 euro"
                },
                new Items
                {
                    Picture="jeep.jpg",
                    Name = "Jeep Grand Cherokee",
                    An = "2008",
                    Price = "4500 euro"
                },
                new Items
                {
                    Picture="ford.jpg",
                    Name = "Ford Transit",
                    An = "2009",
                    Price = "4000 euro"
                }
            };

            CartItems = new ObservableCollection<Items> { };
            CartItemclick = new Command<Items>(executeCartitemclickcommand);
             this.navigation = navigation;
             Itemclick = new Command<Items>(executeitemclickcommand);
        }
        private INavigation navigation;

        async void executeitemclickcommand(Items item)
        {
            this.SelectedItem = item;
            await navigation.PushModalAsync(new DetailPage(this));
        }

        async void executeCartitemclickcommand(Items item)
        {
            this.CartItems.Add(this.SelectedItem);
            await navigation.PushModalAsync(new CartPage(this));

        }
    }
}