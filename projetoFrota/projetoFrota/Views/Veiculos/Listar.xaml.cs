using projetoFrota.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetoFrota.Views.Veiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listar : ContentPage
    {
        public Listar()
        {
            InitializeComponent();
        }

        protected override  void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ListaVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
    }
}