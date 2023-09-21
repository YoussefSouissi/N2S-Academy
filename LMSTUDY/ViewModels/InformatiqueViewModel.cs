using System;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using LMSTUDY.Models;
using FormationModel = LMSTUDY.Models.InformatiqueModel;
namespace LMSTUDY.ViewModels
{
    public class InformatiqueViewModel
    {
        public ObservableCollection<InformatiqueModel> InformatiqueItems { get; set; }
        public System.Guid SelectedCategoryId { get; set; } 

        public InformatiqueViewModel()
        {
            InformatiqueItems = new ObservableCollection<InformatiqueModel>();
        }

        public async Task LoadFormationsByCategory()
        {
            try
            {
                var apiUrl = $"https://10.0.2.2:7107/api/Formation/ByCategory/{SelectedCategoryId}";

                var httpClient = new HttpClientService().GetPlatformSpecificHttpClient();
                var formations = await httpClient.GetFromJsonAsync<List<InformatiqueModel>>(apiUrl);

                InformatiqueItems.Clear();
                foreach (var formation in formations)
                {
                    InformatiqueItems.Add(formation);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }



}
