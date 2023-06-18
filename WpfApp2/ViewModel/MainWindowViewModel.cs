using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Domain.Entities;
using WpfApp2.Infrastructure.Persistence;

namespace WpfApp2.ViewModel
{
     public class MainWindowViewModel:ViewModelBase
     {
        private User _user;
        private List<Product> _products;

        public User User
        {
            get => _user; set => Set(ref _user, value, nameof(User));

        }

        public List<Product> Products { get => _products; set => Set(ref _products, value, nameof(Products)); }

        public MainWindowViewModel() 
        {
            Products = GetProducts();
        
        
        }


        public List<string> AddItm = new List<string>
        {
            "Добавить продукт"
        };
        

        private List<Product> GetProducts()
        {
            using(var context = new ApplicationDbContext())
            {
                return context.Product.ToList();
            }
        }


     }
}
