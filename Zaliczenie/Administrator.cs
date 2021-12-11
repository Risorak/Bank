using System;
using System.Collections.Generic;
using System.Text;

namespace Zaliczenie
{
    class Administrator
    {
        private string Nazwa;
        private List<Użytkownik> klient;


        public Administrator(string Nazwa)
        {
            this.Nazwa = Nazwa;
            this.klient = new List<Użytkownik>();
        }

        public void DodajUżytkownika(Użytkownik klient)
        {
            this.klient.Add(klient);
        }

        public void UsuńUżytkownika(Użytkownik klient)
        {
            this.klient.Add(klient);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Użytkownik uż in this.klient)
            {
                stringBuilder.Append(uż.GetName());
                stringBuilder.Append("\n");
            }

            stringBuilder.Append("Klienci");
            return $"Bank:{Nazwa}, Klienci:\n{stringBuilder}";
        }
    }
}
