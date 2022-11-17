using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            {
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        private ObservableCollection<String> tipos;

        public ObservableCollection<String> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                NotifyPropertyChanged("Tipos");
            }
        }

        public MainWindowVM()
        {
            Platos = new ObservableCollection<Plato>();

            Tipos = new ObservableCollection<string> { "Americana", "China", "Mexicana" };

            Platos = Plato.GetSamples("C:\\Users\\alumno\\Desktop\\dam2\\DINT\\Tema5\\Actividades\\ut5_actividades_1\\Imagenes");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
