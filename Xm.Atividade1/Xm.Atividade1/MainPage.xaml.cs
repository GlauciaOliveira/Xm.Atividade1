using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xm.Atividade1.Model;

namespace Xm.Atividade1
{
    public partial class MainPage : ContentPage
    {
        Email maillerModel;

        public MainPage()
        {
            InitializeComponent();

            if (maillerModel == null)
                maillerModel = new Email();
        }

        
        private void btnMail_Clicked(object sender, EventArgs e)
        {
            if ((maillerModel.Ativo) && (!string.IsNullOrEmpty(maillerModel.MailAccount)))
                DisplayAlert("Mensagem",
                    $"E-mail enviado para {maillerModel.MailAccount}", "Ok");
            else
                DisplayAlert("Mensagem", "Envio não autorizado", "Ok");

        }

        private async void btnConfig_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage(){ BindingContext = maillerModel });
        }
    }
}
