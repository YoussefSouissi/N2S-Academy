using LMSTUDY.Models;
using System.Collections.ObjectModel;

namespace LMSTUDY.ViewModels
{
    class AvantagesViewModel
    {
        #region Properties
        public ObservableCollection<AvantagesModel> Avantages { get; set; } = new ObservableCollection<AvantagesModel> { };
        #endregion
        public AvantagesViewModel()
        {
            Avantages.Add(new AvantagesModel
            {
                AvantageTitle = "Coût réduit",
                AvantageDescription = "Le premier avantage de la formation en entreprise est qu’elle coûte moins cher que l’envoi d’employés à des cours de formation externes. La formation en entreprise est la solution la plus économique pour un minimum de 4 employés et un maximum de 12.",
                AvantageImage = "cout_reduit"
            });



            Avantages.Add(new AvantagesModel
            {
                AvantageTitle = "Rapidité de mise en œuvre",
                AvantageDescription = "Selon votre calendrier et vos besoins, un devis, des dates, et un consultant vous seront proposés dans les meilleurs délais",
                AvantageImage = "rapidite"
            });

            Avantages.Add(new AvantagesModel
            {
                AvantageTitle = "Flexibilité d’organisation",
                AvantageDescription = "Selon votre calendrier et vos besoins, un devis, des dates, et un consultant vous seront proposés dans les meilleurs délais.",
                AvantageImage = "metier"
            });

            Avantages.Add(new AvantagesModel
            {
                AvantageTitle = "Cohésion interne renforcée",
                AvantageDescription = "La formation interne permet aux employés de se familiariser avec le contexte, la culture et les valeurs propres à l’entreprise. Ce faisant, ils seront mieux à même de se comprendre et de contextualiser la formation avec les problématiques propres à l’entreprise.",
                AvantageImage = "cohesion_interne_renforcee"
            });
        }


    }
}
