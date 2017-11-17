using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    /// <summary>
    /// Simple adition class
    /// </summary>
    public class Addition
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="v1">1ère valeur double</param>
        /// <param name="v2">Seconde valeur double</param>
        public Addition(double v1, double v2)
        {
            this.val1 = v1;
            this.val2 = v2;
        }

        /// <summary>
        /// Addition des 2 valeurs
        /// </summary>
        /// <returns>Resultat de l'addition</returns>
        public double Additionne()
        {
            return val1 + val2;
        }

        /// <summary>
        /// Get 1ère valeur
        /// </summary>
        /// <returns>valeur</returns>
        public double getVal1()
        {
            return this.val1;
        }

        /// <summary>
        /// Get seconde valeur
        /// </summary>
        /// <returns>valeur</returns>
        public double getVal2()
        {
            return this.val2;
        }

        /// <summary>
        /// Set la 1ère valeur
        /// </summary>
        /// <param name="val">valeur</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }

        /// <summary>
        /// Set la seconde valeur
        /// </summary>
        /// <param name="val">valeur</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }

        /// <summary>
        /// Affiche info class
        /// </summary>
        /// <returns></returns>
        public string Affiche()
        {
            return "The summ of " + val1.ToString() + "and" + val2.ToString() + "is" + (val1 + val2).ToString();
        }
    }
}

