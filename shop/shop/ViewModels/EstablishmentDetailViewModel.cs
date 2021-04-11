using MvvmHelpers;
using Newtonsoft.Json;
using shop.Models;
using shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace shop.ViewModels {
    [QueryProperty("establishmentSerialized", "establishmentSerialized")]
    public class EstablishmentDetailViewModel:BaseViewModel {
        public Establishment Establishment { get; set; }
        public String establishmentSerialized {
            set {
              Establishment = JsonConvert.DeserializeObject<Establishment>( Uri.UnescapeDataString(value));
              OnPropertyChanged(nameof(Establishment));
            } 
        }
        public EstablishmentDetailViewModel() {
            
            
        }

    }
}
