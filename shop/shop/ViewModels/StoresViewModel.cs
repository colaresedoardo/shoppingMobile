
using Newtonsoft.Json;
using shop.Libraries.Enums;
using shop.Libraries.Helpers.MVVM;
using shop.Models;
using shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace shop.ViewModels {

    public class StoresViewModel : EstablishmentViewModel {
        public StoresViewModel(EstablishmentType establishmenType) : base(establishmenType) {
        }
    }
}
