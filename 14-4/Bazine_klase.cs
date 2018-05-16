using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4
{
    class Alkoholis
    {
        private double Laipsniai { get; set; }
        public int Turis {get;}
        public string Spalva { get; }

        public double GetLaipsniai ()
        {
            return Laipsniai;
        }

        public void SetLaipsniai(double Laipsniai)
        {
            this.Laipsniai = Laipsniai;
        }

        public Alkoholis()
        {

        }

        /// <summary>
        /// Skaiciuoja gaminio amziu
        /// </summary>
        /// <param name="gamybosMetus"></param>
        /// <returns></returns>
        public int Amzius(DateTime gamybosMetus)
        {
            return (DateTime.Today.Year - gamybosMetus.Year);
        }

        public Alkoholis (double Laipsniai, int Turis, string Spalva)
        {
            this.Laipsniai = Laipsniai;
            this.Turis = Turis;
            this.Spalva = Spalva;
        }
    }
}
