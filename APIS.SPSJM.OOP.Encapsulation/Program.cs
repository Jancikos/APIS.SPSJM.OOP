
using APIS.SPSJM.OOP.Encapsulation;

var sklenik1 = new Sklenik()
{
    Senzory =
    {
        new Senzor(),
        new Senzor()
    },
    OsvetlenieZapnute = true
};

var sklenik2 = new Sklenik()
{
    Senzory =
    {
        new Senzor(),
        new Senzor()
    },
    OsvetlenieZapnute = false
};

Console.WriteLine($"#1 {sklenik1}");
Console.WriteLine($"#2 {sklenik2}");
