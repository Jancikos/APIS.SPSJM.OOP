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

static void ViaceroSklenikovViaceroSenzorov()
{
    double sklenik1Teplota1 = 36.6;
    double sklenik1Teplota2 = 37.2;
    int sklenik1Vlhkost1 = 88;
    int sklenik1Vlhkost2 = 85;
    bool sklenik1SvetloZapnute = true;

    double sklenik2Teplota1 = 34.5;
    double sklenik2Teplota2 = 35.0;
    int sklenik2Vlhkost1 = 90;;
    int sklenik2Vlhkost2 = 92;
    bool sklenik2SvetloZapnute = false;

    double sklenik1PriemernaTeplota = (sklenik1Teplota1 + sklenik1Teplota2) / 2;
    double sklenik1PriemernaVlhkost = (sklenik1Vlhkost1 + sklenik1Vlhkost2) / 2.0;

    double sklenik2PriemernaTeplota = (sklenik2Teplota1 + sklenik2Teplota2) / 2;
    double sklenik2PriemernaVlhkost = (sklenik2Vlhkost1 + sklenik2Vlhkost2) / 2.0;

    Console.WriteLine($"Sklenik 1: Priemerna teplota {sklenik1PriemernaTeplota}°C, priemerna vlhkost {sklenik1PriemernaVlhkost}%, svetlo je {(sklenik1SvetloZapnute ? "zapnute" : "vypnute")}.");
    Console.WriteLine($"Sklenik 2: Priemerna teplota {sklenik2PriemernaTeplota}°C, priemerna vlhkost {sklenik2PriemernaVlhkost}%, svetlo je {(sklenik2SvetloZapnute ? "zapnute" : "vypnute")}.");
}


