namespace Bai09.Models;

using Bai09.Interfaces;
public class SmartDoor : IDevice, ILockable
{
    public string Name { get; }
    public SmartDoor(string name) => Name = name;

    public void TurnOn() => Console.WriteLine($"{Name}: ON");
    public void TurnOff() => Console.WriteLine($"{Name}: OFF");
    public void Lock() => Console.WriteLine($"{Name}: LOCKED");
    public void Unlock() => Console.WriteLine($"{Name}: UNLOCKED");
}