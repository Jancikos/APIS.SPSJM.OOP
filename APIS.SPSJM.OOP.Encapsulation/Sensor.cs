using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIS.SPSJM.OOP.Encapsulation
{
    public class Senzor
    {
        private double _teplota;
        public double Teplota
        {
            get { return _teplota; }
        }

        private double _vlhkost;
        public double Vlhkost => _vlhkost;

        public Senzor()
        {
            SpustiMeranie();
        }

        public void SpustiMeranie()
        {
            var rand = new Random();
            _teplota = rand.NextDouble() * 40.0; // Simulovaná teplota medzi 0 a 40 °C
            _vlhkost = rand.NextDouble() * 100.0; // Simulovaná vlhkosť medzi 0 a 100 %
        }
    }
}
