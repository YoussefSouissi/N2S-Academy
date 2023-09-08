using LMSTUDY.Models;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.Controls.Device;

namespace LMSTUDY.ViewModels
{
  public  class IntroScreenViewModel
    {
        #region Properties
        public ObservableCollection<IntroScreenModel> IntroScreens { get; set; } = new ObservableCollection<IntroScreenModel> { };
        #endregion
        public IntroScreenViewModel() {
            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Financement de la formation",
                IntroDescription = "Afin de rendre nos formations plus accessibles, Nous vous accompagnons pour le financement de votre formation avec nos banques partenaires qui peuvent vous accorder des prêts à des taux aussi bas que 2% .",
                IntroImage = "formation_adopte"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Suivi et coaching",
                IntroDescription = "En vous inscrivant à nos programmes, vous accéderez à nos services de placement incluant l'assistance pour CV, lettre de motivation, préparation aux entretiens, recherche d'emplois, et plus encore, pour vous accompagner vers votre emploi idéal.",
                IntroImage = "coaching"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Évaluation du niveau initial",
                IntroDescription = "N2S Academy propose un processus d’évaluation complet, comprenant des évaluations et des entretiens individualisés, afin de s’assurer que nous formons ceux qui en ont le plus besoin.",
                IntroImage = "evaluation"
            });

            IntroScreens.Add(new IntroScreenModel
            {
                IntroTitle = "Programme de placement",
                IntroDescription = "Grâce à notre programme de placement, nous avons fait la preuve de notre capacité à placer nos étudiants dans des stages ou des emplois de leurs rêves chez l’un de nos partenaires professionnels.",
                IntroImage = "metier"
            });
        }
    }
}