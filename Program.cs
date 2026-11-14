using Bai09.Models;
using Bai09.Interfaces;

/*  
202418946
Phạm Văn Minh
*/

// 1. Tạo light, fan, door
Console.WriteLine("1. Tạo các thiết bị: light, fan, door");
IDevice light = DeviceFactory.Create("light", "Living room light");
IDevice fan = DeviceFactory.Create("fan", "Living room fan");
IDevice door = DeviceFactory.Create("door", "Main door");
// 2. Tạo loại camera khi chưa hỗ trợ
Console.WriteLine("2. Tạo loại camera khi chưa hỗ trợ");
try
{
    IDevice camera = DeviceFactory.Create("camera", "Front camera");

}
catch (ArgumentException ex)
{
    Console.WriteLine($"Lỗi: {ex.Message}");
}
// 3. Lấy HomeConfiguration.Instance hai lần
Console.WriteLine("3. Lấy HomeConfiguration.Instance hai lần");
var c1 = HomeConfiguration.Instance;
var c2 = HomeConfiguration.Instance;
if (!ReferenceEquals(c1, c2))
{
    throw new Exception("Singleton implementation is incorrect.");
}
else
{
    Console.WriteLine("Singleton implementation is correct.");
}
// 4. Gọi GoToWork()
Console.WriteLine("4. Gọi GoToWork()");
SmartHomeFacade smartHome = new(light, fan, (ILockable)door);
smartHome.GoToWork();
// 5. Gọi GoToSleep()
Console.WriteLine("5. Gọi GoToSleep()");
smartHome.GoToSleep();
