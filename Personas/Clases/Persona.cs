using System;

namespace Personas.Clases
{
    public class Persona : Notificable
    {
        private string nombre;
        private string pais;
        private DateTime fecha_Nacimiento;
        private float saldo;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value) { return; }
                nombre = value;
                OnPropertyChanged();
            }
        }
        public string Pais
        {
            get => pais;
            set
            {
                if (pais == value) { return; }
                pais = value;
                OnPropertyChanged();
            }
        }
        public DateTime Fecha_Nacimiento
        {
            get => fecha_Nacimiento; set
            {
                if(fecha_Nacimiento == value) { return; }
                fecha_Nacimiento = value;
                OnPropertyChanged();
            }
        }

        public float Saldo
        {
            get => saldo; set
            {
                if (value == saldo) { return; }
                saldo = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"{Nombre} | {pais} | {fecha_Nacimiento} | {saldo}";
        }
    }
}
