public struct Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class CoordinateClass
{
    public int X { get; set; }
    public int Y { get; set; }
}

public static class MemoryDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Task 1.9: Memory Model -----");

        // 1. Two ints
        int firstNumber = 10;
        int secondNumber = firstNumber;

        secondNumber = 20;

        Console.WriteLine($"firstNumber = {firstNumber}");
        Console.WriteLine($"secondNumber = {secondNumber}");

        // Explanation:
        // int is a value type. Copying firstNumber to secondNumber copies the value 10.
        // Changing secondNumber to 20 does not change firstNumber.
        // Therefore, the output is 10 and 20.


        // 2. int array
        int[] firstArray = { 10, 20, 30 };
        int[] secondArray = firstArray;

        secondArray[0] = 99;

        Console.WriteLine($"firstArray[0] = {firstArray[0]}");
        Console.WriteLine($"secondArray[0] = {secondArray[0]}");

        // Explanation:
        // An array is a reference type. Copying firstArray to secondArray copies the reference,
        // so both variables point to the same array object.
        // Changing secondArray[0] also changes firstArray[0].
        // Therefore, both outputs are 99.


        // 3. Coordinate struct
        Coordinate firstCoordinate = new Coordinate
        {
            X = 10,
            Y = 20
        };

        Coordinate secondCoordinate = firstCoordinate;

        secondCoordinate.X = 99;

        Console.WriteLine($"firstCoordinate.X = {firstCoordinate.X}");
        Console.WriteLine($"secondCoordinate.X = {secondCoordinate.X}");

        // Explanation:
        // Coordinate is a struct, which is a value type.
        // Copying firstCoordinate creates a separate copy of the struct.
        // Changing secondCoordinate.X does not change firstCoordinate.X.
        // Therefore, the output is 10 and 99.


        // 4. Coordinate class
        CoordinateClass firstCoordinateClass = new CoordinateClass
        {
            X = 10,
            Y = 20
        };

        CoordinateClass secondCoordinateClass = firstCoordinateClass;

        secondCoordinateClass.X = 99;

        Console.WriteLine($"firstCoordinateClass.X = {firstCoordinateClass.X}");
        Console.WriteLine($"secondCoordinateClass.X = {secondCoordinateClass.X}");

        // Explanation:
        // CoordinateClass is a class, which is a reference type.
        // Copying firstCoordinateClass to secondCoordinateClass copies the reference,
        // so both variables point to the same object.
        // Changing secondCoordinateClass.X also changes firstCoordinateClass.X.
        // Therefore, both outputs are 99.
    }
}