using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Estilo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeralView : ContentPage
    {
        public GeralView()
        {
            InitializeComponent();
        }

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.GeralView());
        }
    }
}