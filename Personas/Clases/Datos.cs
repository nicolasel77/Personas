using System;
using System.Collections.ObjectModel;

namespace Personas.Clases
{
    public class Datos : Notificable
    {
        private ObservableCollection<Persona> personas;
        private Persona persona_Seleccionada;

        public Datos()
        {
            Personas = new ObservableCollection<Persona>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Personas.Add(new Persona() { Nombre = "Nombre " + i, Pais = "País " + i, Fecha_Nacimiento = new DateTime(1977 + i, i + 1, 1), Saldo = Convert.ToSingle(random.Next(10, 5000) * 3.14)});

            }
        }
        public ObservableCollection<Persona> Personas
        {
            get => personas; set
            {
                if (personas == value) { return; }
                personas = value;
                OnPropertyChanged();
            }
        }

        public Persona Persona_Seleccionada
        {
            get => persona_Seleccionada; set
            {
                if(persona_Seleccionada == value) { return; }
                persona_Seleccionada = value;
                OnPropertyChanged();
            }
        }
    }
}
