
using APIS.SPSJM.OOP.Triedy;

var sklenik1 = new Sklenik()
{
    Senzory =
    {
        new Senzor() { Teplota = 22.5, Vlhkost = 55.0 },
        new Senzor() { Teplota = 23.0, Vlhkost = 50.0 }
    },
    OsvetlenieZapnute = true
};

var sklenik2 = new Sklenik()
{
    Senzory =
    {
        new Senzor() { Teplota = 20.0, Vlhkost = 60.0 },
        new Senzor() { Teplota = 21.5, Vlhkost = 58.0 }
    },
    OsvetlenieZapnute = false
};

Console.WriteLine($"#1 {sklenik1.}");
Console.WriteLine($"#2 {sklenik2}");

