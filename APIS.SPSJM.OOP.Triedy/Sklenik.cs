using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIS.SPSJM.OOP.Triedy;

public class Sklenik
{
    public List<Senzor> Senzory { get; set; }


    public bool OsvetlenieZapnute { get; set; }

    private bool _dvereOtvorene = false;
    public bool DvereOtvorene
    {
        get { return _dvereOtvorene; }
        set
        {
            _dvereOtvorene = value;
        }
    }

    // Konštruktor
    public Sklenik()
    {
        Senzory = new List<Senzor>();
        OsvetlenieZapnute = false;
    }

    // Verejná metóda
    public double PriemernaTeplota()
    {
        if (Senzory.Count == 0)
            return 0.0;

        double sumaTeplot = 0.0;
        foreach (var senzor in Senzory)
        {
            sumaTeplot += senzor.Teplota;
        }
        return sumaTeplot / Senzory.Count;
    }

    // Verejná metóda (použitie LINQ a arrow function syntax)
    public double PriemernaVlhkost() => (Senzory.Count == 0) ? 0.0 : Senzory.Average(s => s.Vlhkost);

    // Verejná metóda, preťažená (override) z predka Object
    public override string ToString()
    {
        return $"Sklenik: Priemerna Teplota = {PriemernaTeplota():F2} °C, Priemerna Vlhkost = {PriemernaVlhkost():F2} %, Osvetlenie = {(OsvetlenieZapnute ? "Zapnute" : "Vypnute")}";
    }
}
