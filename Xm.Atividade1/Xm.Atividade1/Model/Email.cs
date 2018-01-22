using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Xm.Atividade1.Model
{
    public class Email : INotifyPropertyChanged
    {
        public bool ativo;
        public bool Ativo
        {
            get
            {
                return ativo;
            }
            set
            {
                ativo = value;

                if (!ativo) MailAccount = string.Empty;
            }
        }
        private string mailAccount;
        public string MailAccount
        {
            get
            {
                return mailAccount;
            }
            set
            {
                mailAccount = value;
                EventPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
