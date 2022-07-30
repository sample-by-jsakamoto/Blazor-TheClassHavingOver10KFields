using Shared;

var obj1 = Test.CreateInstanceOfTheClassHavingOver10KFields_AssignFiledValueDirectly();
var obj2 = Test.CreateInstanceOfTheClassHavingOver10KFields_AssignFiledValueByReflection();

Console.WriteLine("Get the field value directly of the object assigned that value directly:");
Console.WriteLine(Test.GetFiledValueDirectly(obj1));
Console.WriteLine("Get the field value by reflection of the object assigned that value directly:");
Console.WriteLine(Test.GetFiledValueByReflection(obj1));

Console.WriteLine("Get the field value directly of the object assigned that value by reflection:");
Console.WriteLine(Test.GetFiledValueDirectly(obj2));
Console.WriteLine("Get the field value by reflection of the object assigned that value by reflection:");
Console.WriteLine(Test.GetFiledValueByReflection(obj2));
