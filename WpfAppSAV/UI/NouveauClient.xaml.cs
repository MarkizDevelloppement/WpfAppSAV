using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppSAV.Metier;

namespace WpfAppSAV.UI
{
    /// <summary>
    /// Interaction logic for NouveauClient.xaml
    /// </summary>
    public partial class NouveauClient : Window
    {
        public NouveauClient()
        {
            InitializeComponent();
        }
        
        private void Creer()
        {
            // récupérer le contenue des textbox dans des variables
            String TextNom = this.NomTextbox.Text;
            String TextPrénom = this.Prénom.Text;
            String TextModelPhone = this.ModelPhone.Text;
            int TextMobile = int.Parse(this.Mobile.Text); ;
            String TextEmail = this.Email.Text;
            int TextDate = int.Parse(this.DateRecue.Text);
            String TextDescrip = this.Descxription.Text;
            String TextStat = this.Statuts.Text;
            int TextPrix = int.Parse(this.PrixReparation.Text);


            // créer un object réparation a l'aide de ses variables

            Reparation NewClient = new Reparation(TextNom, TextPrénom, TextModelPhone, TextMobile, TextEmail, new DateTime(TextDate),
                             TextDescrip, TextStat, TextPrix);
            Business.Reparation.Add(NewClient);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Creer();
        }
    }
}
