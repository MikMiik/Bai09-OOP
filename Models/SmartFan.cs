namespace Bai09.Models;

using Bai09.Interfaces;

public class SmartFan : IDevice
{
    public string Name { get; }
    public SmartFan(string name)
    {
        Name = name;
    }

    public void TurnOn() => Console.WriteLine($"{Name}: ON");
    public void TurnOff() => Console.WriteLine($"{Name}: OFF");
}
