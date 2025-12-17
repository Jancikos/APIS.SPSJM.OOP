using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIS.SPSJM.OOP.Dedenie
{
    // Abstraktna trieda - nemôže byť inštanciovaná priamo
    public abstract class Senzor
    {
        // Statický atribút - zdieľaný medzi všetkými inštanciami triedy
        public static int TotalSensorsCreated { get; private set; } = 0;
        public int ID { get; init; }

        protected double _posledneNameranaTeplota;
        public virtual double Teplota => _posledneNameranaTeplota;
        protected double _posledneNameranaVlhkost;
        public virtual double Vlhkost => _posledneNameranaVlhkost;

        // Konštruktor
        public Senzor()
        {
            ID = ++TotalSensorsCreated;
            SpustiMeranie();
        }

        // Abstraktná metóda - musí byť implementovaná v odvodených triedach
        public abstract void SpustiMeranie();
    }

    public class BoschSenzor : Senzor
    {
        // implementácia abstraktnej metódy
        public override void SpustiMeranie()
        {
            var rand = new Random();
            _posledneNameranaTeplota = rand.NextDouble() * 40.0;
            _posledneNameranaVlhkost = rand.NextDouble() * 100.0;
        }
    }

    public class XiaomiSenzor : Senzor
    {
        // zavedenie atributu koeficientu vlhkosti, iba pre tento typ senzora
        private double _koeficientVlhkosti;

        // prepis getera vlastnosti Vlhkost
        public override double Vlhkost => _posledneNameranaVlhkost * _koeficientVlhkosti;

        // implementácia abstraktnej metódy
        public override void SpustiMeranie()
        {
            _posledneNameranaTeplota = Random.Shared.NextDouble() * 40.0;
            _posledneNameranaVlhkost = Random.Shared.NextDouble() * 100.0;
            _koeficientVlhkosti = 0.8 + Random.Shared.NextDouble();
        }
    }
}
