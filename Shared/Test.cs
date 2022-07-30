using System.Reflection;

namespace Shared;

public static class Test
{
    public static TheClassHavingOver10KFields CreateInstanceOfTheClassHavingOver10KFields_AssignFiledValueDirectly()
    {
        var obj = new TheClassHavingOver10KFields();
        obj._40000 = "\"Assign a value directly.\"";
        return obj;
    }

    public static TheClassHavingOver10KFields CreateInstanceOfTheClassHavingOver10KFields_AssignFiledValueByReflection()
    {
        var obj = new TheClassHavingOver10KFields();
        var fieldInfo = typeof(TheClassHavingOver10KFields).GetField(nameof(TheClassHavingOver10KFields._40000), BindingFlags.Public | BindingFlags.Instance);
        fieldInfo.SetValue(obj, "\"Assign a value by reflection.\"");
        return obj;
    }

    public static string? GetFiledValueDirectly(TheClassHavingOver10KFields obj)
    {
        return obj._40000;
    }

    public static string? GetFiledValueByReflection(TheClassHavingOver10KFields obj)
    {
        var fieldInfo = typeof(TheClassHavingOver10KFields).GetField(nameof(TheClassHavingOver10KFields._40000), BindingFlags.Public | BindingFlags.Instance);
        return fieldInfo.GetValue(obj) as string;
    }
}
