
using APIS.SPSJM.OOP.Dedenie;

var sklenik1 = new Sklenik()
{
    Senzory =
    {
        // new Senzor(), // Toto by spôsobilo chybu, pretože Senzor je abstraktná trieda
        new BoschSenzor(),
        new BoschSenzor()
    },
    OsvetlenieZapnute = true
};

var sklenik2 = new Sklenik()
{
    Senzory =
    {
        new XiaomiSenzor(),
        new XiaomiSenzor(),
        new BoschSenzor(),
        new BoschSenzor(),
        new XiaomiSenzor()
    },
    OsvetlenieZapnute = false
};

Console.WriteLine($"#1 {sklenik1}");
Console.WriteLine($"#2 {sklenik2}");
