using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanos
{
    class romanos
    {
        private int numeroInt;
        private string numeroRom;

        public romanos(string numero)
        {
            int tamanho = numero.Length - 1;
            this.numeroRom = numero;

            for(int i = tamanho; i>=0 ; i--)
            {
                if (i != 0 && numero[i] == 'M' && numero[i - 1] == 'C')
                {
                        this.numeroInt += 900;
                        this.numeroInt -= 100;
                }

                else if (i != 0 && numero[i] == 'D' && numero[i - 1] == 'C')
                {
                    this.numeroInt += 400;
                    this.numeroInt -= 100;
                }

                else if (i != 0 && numero[i] == 'C' && numero[i - 1] == 'X')
                {
                    this.numeroInt += 90;
                    this.numeroInt -= 10;
                }

                else if (i != 0 && numero[i] == 'L' && numero[i - 1] == 'X')
                {
                    this.numeroInt += 40;
                    this.numeroInt -= 10;
                }

                else if (i != 0 && numero[i] == 'V' && numero[i - 1] == 'I')
                {
                    this.numeroInt += 4;
                    this.numeroInt -= 1;
                }
                else if (i != 0 && numero[i] == 'X' && numero[i - 1] == 'I')
                {
                    this.numeroInt += 9;
                    this.numeroInt -= 1;
                }
                else if (numero[i] == 'M')
                {
                    this.numeroInt += 1000;
                }

                else if (numero[i] == 'D')
                {
                    this.numeroInt += 500;
                }

                else if (numero[i] == 'C')
                {
                    this.numeroInt += 100;
                }

                else if (numero[i] == 'L')
                {
                    this.numeroInt += 50;
                }
                else if (numero[i] == 'X')
                {
                    this.numeroInt += 10;
                }

                else if (numero[i] == 'V')
                {
                    this.numeroInt += 5;
                }

                else if (numero[i] == 'I')
                {
                    this.numeroInt += 1;
                }

            }
        }
        public romanos(int numero)
        {
            int m, ce, de, un, resto;

            this.numeroInt = numero;

            m = numero / 1000;
            resto = numero % 1000;
            ce = resto / 100;
            resto = resto % 100;
            de = resto / 10;
            resto = resto % 10;
            un = resto;

            switch(m)
            {
                case 1: this.numeroRom += "M"; break;
                case 2: this.numeroRom += "MM"; break;
                case 3: this.numeroRom += "MMM"; break;
            }
            switch (ce)
            {
                case 1: this.numeroRom += "C"; break;
                case 2: this.numeroRom += "CC"; break;
                case 3: this.numeroRom += "CCC"; break;
                case 4: this.numeroRom += "CD"; break;
                case 5: this.numeroRom += "D"; break;
                case 6: this.numeroRom += "DC"; break;
                case 7: this.numeroRom += "DCC"; break;
                case 8: this.numeroRom += "DCCC"; break;
                case 9: this.numeroRom += "CM"; break;
            }
            switch (de)
            {
                case 1:
                    this.numeroRom += "X";
                    break;
                case 2:
                    this.numeroRom += "XX";
                    break;
                case 3:
                    this.numeroRom += "XXX";
                    break;
                case 4:
                    this.numeroRom += "XL";
                    break;
                case 5:
                    this.numeroRom += "L";
                    break;
                case 6:
                    this.numeroRom += "LX";
                    break;
                case 7:
                    this.numeroRom += "LXX";
                    break;
                case 8:
                    this.numeroRom += "LXXX";
                    break;
                case 9:
                    this.numeroRom += "XC";
                    break;
            }
            switch (un)
            {
                case 1: this.numeroRom += "I"; ; break;
                case 2: this.numeroRom += "II"; ; break;
                case 3: this.numeroRom += "III"; ; break;
                case 4: this.numeroRom += "IV"; ; break;
                case 5: this.numeroRom += "V"; break;
                case 6: this.numeroRom += "VI"; break;
                case 7: this.numeroRom += "VII"; break;
                case 8: this.numeroRom += "VIII"; break;
                case 9: this.numeroRom += "IX"; break;
            }
        }

        public override string ToString()
        {
          return this.numeroRom;
        }
        public static int operator +(romanos num1, romanos num2)
        {
            return num1.numeroInt + num2.numeroInt;
        }
        public static int operator -(romanos num1, romanos num2)
        {
            return num1.numeroInt - num2.numeroInt;
        }
        public static int operator *(romanos num1, romanos num2)
        {
            return num1.numeroInt * num2.numeroInt;
        }
        public static int operator /(romanos num1, romanos num2)
        {
            return num1.numeroInt / num2.numeroInt;
        }
    }
}