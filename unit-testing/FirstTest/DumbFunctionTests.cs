using System;

public class DumbFunctionTests
{
    public static void DumbFunction_ReturnsTrueIf0_ReturnsTrue() => Console.WriteLine(DumbFunction.ReturnsTrueIf0(0) ? "Pass" : "Fail");
}
