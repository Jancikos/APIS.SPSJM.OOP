SklenikJednoducho();
SklenikViaceroSenzorov();
SklenikViaceroSenzorovPolia();

static void SklenikJednoducho()
{
    double teplota = 36.6;
    int vlhkost = 88;
    bool svetloZapnute = true;

    Console.WriteLine($"V skleniku je teplota {teplota}°C, vlhkost {vlhkost}% a svetlo je {(svetloZapnute ? "zapnute" : "vypnute")}.");
}

static void SklenikViaceroSenzorovPolia()
{
    double[] teploty = { 36.6, 37.2, 35.9, 38.1 };
    int[] vlhkosti = { 88, 85  };
    bool svetloZapnute = true;

    Console.WriteLine($"V skleniku je priemerna teplota {_vypocitajPriemernuTeplotu(teploty)}°C, priemerna vlhkost {_vypocitajPriemernuVlhkost(vlhkosti)}% a svetlo je {(svetloZapnute ? "zapnute" : "vypnute")}.");

    double _vypocitajPriemernuTeplotu(double[] teploty)
    {
        double suma = 0;
        foreach (var teplota in teploty)
        {
            suma += teplota;
        }
        return suma / teploty.Length;
    }

    double _vypocitajPriemernuVlhkost(int[] vlhkosti)
    {
        double suma = 0;
        foreach (var vlhkost in vlhkosti)
        {
            suma += vlhkost;
        }
        return suma / vlhkosti.Length;
    }
}

static void SklenikViaceroSenzorov()
{
    double teplota1 = 36.6;
    double teplota2 = 37.2;
    double teplota3 = 35.9;
    double teplota4 = 38.1;

    int vlhkost1 = 88;
    int vlhkost2 = 85;

    bool svetloZapnute = true;

    double priemernaTeplota = (teplota1 + teplota2 + teplota3 + teplota4) / 4;
    double priemernaVlhkost = (vlhkost1 + vlhkost2) / 2.0;

    Console.WriteLine($"V skleniku je priemerna teplota {priemernaTeplota}°C, priemerna vlhkost {priemernaVlhkost}% a svetlo je {(svetloZapnute ? "zapnute" : "vypnute")}.");
}

static void ViaceroSklenikov()
{
    double teplotaSklenik1 = 36.6;
    int vlhkostSklenik1 = 88;
    bool svetloZapnuteSklenik1 = true;

    double teplotaSklenik2 = 34.5;
    int vlhkostSklenik2 = 92;
    bool svetloZapnuteSklenik2 = false;

    Console.WriteLine($"Sklenik 1: Teplota {teplotaSklenik1}°C, Vlhkost {vlhkostSklenik1}%, Svetlo {(svetloZapnuteSklenik1 ? "zapnute" : "vypnute")}");
    Console.WriteLine($"Sklenik 2: Teplota {teplotaSklenik2}°C, Vlhkost {vlhkostSklenik2}%, Svetlo {(svetloZapnuteSklenik2 ? "zapnute" : "vypnute")}");
}


