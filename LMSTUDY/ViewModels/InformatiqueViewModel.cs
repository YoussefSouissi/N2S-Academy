using System;
using System.Collections.ObjectModel;
using LMSTUDY.Models;

namespace LMSTUDY.ViewModels
{
    public class InformatiqueViewModel
    {
        public ObservableCollection<InformatiqueModel> InformatiqueItems { get; set; }

        public InformatiqueViewModel()
        {
            InformatiqueItems = new ObservableCollection<InformatiqueModel>();

            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });

            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            InformatiqueItems.Add(new InformatiqueModel
            {
                Name = "Angular",
                Description = "Formation Angular",
                Price = 400m,
                Image = "angular.svg"
            });
            // You can add more items like this...
        }
    }
}
