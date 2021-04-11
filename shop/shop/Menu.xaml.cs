﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shop {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Shell {
        public Menu() {
            InitializeComponent();
            Routing.RegisterRoute("establishment/detail", typeof(Views.EstablishmentDetail));
        }
    }
}