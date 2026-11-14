namespace Bai09.Models;

using Bai09.Interfaces;

public sealed class SmartHomeFacade
{
    private readonly IDevice light;
    private readonly IDevice fan;
    private readonly ILockable door;
    public SmartHomeFacade(
    IDevice light,
    IDevice fan,
    ILockable door)
    {
        this.light = light;
        this.fan = fan;
        this.door = door;
    }
    public void GoToWork()
    {
        light.TurnOff();
        fan.TurnOff();
        door.Lock();
    }
    public void GoToSleep()
    {
        fan.TurnOff();
        door.Lock();
        light.TurnOn();
        int level = HomeConfiguration.Instance.NightLightLevel;
        Console.WriteLine($"Night light level: {level}%");
    }
}