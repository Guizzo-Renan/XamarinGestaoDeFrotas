using projetoFrota.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projetoFrota.Views.Abastecimentos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        private List<Veiculo> listaVeiculos;
        private List<Combustivel> listacombustiveis;
        

        public Cadastro()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            
        }

        private void tipoCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Veiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private  void Salvar_Clicked(object sender, EventArgs e)
        {
            

        }

        private  void Excluir_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void Cancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}