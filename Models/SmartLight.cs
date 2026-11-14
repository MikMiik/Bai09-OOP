namespace Bai09.Models;

using Bai09.Interfaces;

public class SmartLight : IDevice
{
    public string Name { get; }
    public SmartLight(string name)
    {
        Name = name;
    }

    public void TurnOn() => Console.WriteLine($"{Name}: ON");
    public void TurnOff() => Console.WriteLine($"{Name}: OFF");
}
