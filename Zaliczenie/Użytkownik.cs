using System;
using System.Collections.Generic;
using System.Text;

namespace Zaliczenie
{
    class Użytkownik
    {
        public string imię;
        public bool zablokowany;
        private int pieniądze;
        public int stankonta;
        public Użytkownik(string imię, bool zablokowany, int pieniądze)
        {
            this.imię = imię;
            this.zablokowany = false;
            this.pieniądze = pieniądze;
        }

        public string GetName()
        {
            return this.imię;
        }

        public int StanKonta()
        {
            return stankonta = pieniądze - 10;
        }


        public int Kredyt()
        {
            int stankonta = pieniądze * 10;
            return stankonta;
        }
        public override string ToString()
        {
            return $"Imię: {imię} StanKonta:{pieniądze}";
        }
    }
}
