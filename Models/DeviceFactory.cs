namespace Bai09.Models;

using Bai09.Interfaces;
public static class DeviceFactory
{
    public static IDevice Create(string type, string name)
    {
        return type.Trim().ToLowerInvariant() switch
        {
            "light" => new SmartLight(name),
            "fan" => new SmartFan(name),
            "door" => new SmartDoor(name),
            _ => throw new ArgumentException(
            $"Unsupported device type: {type}")
        };
    }
}
