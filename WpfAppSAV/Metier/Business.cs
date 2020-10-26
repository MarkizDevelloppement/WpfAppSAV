using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppSAV.Metier
{
    class Business
    {
        public static ObservableCollection<Reparation> Reparation { get; }

        static Business()
        {
          

            Reparation Thor = new Reparation("Toa", "Thor", "SamsungS10", 87253652, "Thor@gmail.com", new DateTime(2020, 10, 20), "écran casser", "en réparation", 12500);
            Reparation Héléne = new Reparation("Toa", "Héléne", "SamsungA10", 87635241, "Héléne@gmail.com", new DateTime(2020, 07, 02), "écran casser", "en réparation", 11500);
            Reparation Aline = new Reparation("Toa", "Aline", "Iphone12", 87862542, "Aline@gmail.com", new DateTime(2020, 09, 10), "Batterie HS", "pièce commandé", 7500);
            Reparation = new ObservableCollection<Reparation>() { Thor, Héléne, Aline };
        }
    }
}
