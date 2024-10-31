using OOP.Constructions;
using OOP.Constructions.DTO;

#region lab2
Console.WriteLine("Hello, World!");
//var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, BuildMaterialEnum.Brick);
Console.WriteLine("Hello, World!");

// lab 2, zad 6,7
//try
//{
//    var construction3 = new Construction(11, 10, 2, 2, null);
//}
//catch (ArgumentException e)
//{
//    Console.Error.WriteLine(e);
//}
#endregion

#region lab3
// lab 3, zad 1,2
Construction construction4 = new();

Console.WriteLine($"Height:\t{construction4.Height}");
Console.WriteLine($"Width:\t{construction4.Width}");
Console.WriteLine($"Entrances:\t{construction4.Entrances}");
Console.WriteLine($"HumanCapacity:\t{construction4.HumanCapacity}");

// lab 3, zad 3,4
CreateConstructionDto CCDto = new(5, 4, 3, BuildMaterialEnum.Concrete);
Construction construction5 = new(CCDto);

// lab3, zad 7
Console.WriteLine($"Koszt:\t{construction5.getSquareCost()}");
#endregion
