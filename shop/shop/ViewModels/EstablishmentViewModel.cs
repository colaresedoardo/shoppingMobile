using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using shop.Libraries.Enums;
using shop.Models;
using shop.Services;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmHelpers;

namespace shop.ViewModels {
    /*
 *View <-> ViewModel <-> Model
 *-commands: focado ações. Chama os métodos
 *-bindings: Vinculos relacionado a propriedes
 *-notifications:
 */
    public abstract class EstablishmentViewModel : BaseViewModel {
        public string SearchWord { get; set; }

        public ICommand SearchCommand { get; set; }

        private List<Establishment> _establishments;
        private EstablishmentType _establishmenType;
        public List<Establishment> Establishments {
            get {
                return _establishments;
            }
            set {
                SetProperty(ref _establishments, value);
                /*
                 * seria a mesma coisa que 
                 * _establishments =value
                 * OnPropertyChanged(Establishments)
                 */
            }
        }

        private List<Establishment> _allEstablishment;

        public ICommand DetailCommand { get; set; }

        public EstablishmentViewModel(EstablishmentType establishmenType) {
            if (String.IsNullOrEmpty(SearchWord)) {
                SearchWord = "";
            }
            _establishmenType = establishmenType;
            //faz o vinculo na hora que carrega a pagina
            SearchCommand = new Command(Search);
            //Indica o tipo de objeto que vai tá passando no parametro
            DetailCommand = new Command<Establishment>(Detail);
            //--------------------------------------------------
            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(e => e.Type == _establishmenType).ToList();
            Establishments = allStores;
            _allEstablishment = allStores;
        }

        private void Search() {
            //TODO - Lógica de filtrar a lista de lojas
            Establishments = _allEstablishment.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
        private void Detail(Establishment establishment) {
            // vai levar para a tela de detalhe definda no menu.xml

            String establishmentSerialized = JsonConvert.SerializeObject(establishment);

            //Para passar parametros precisar serializar para string
            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}");
        }

    }
}
