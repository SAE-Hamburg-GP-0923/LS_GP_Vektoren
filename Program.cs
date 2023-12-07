// See https://aka.ms/new-console-template for more information
namespace LS_GP_Vektoren;

class Program
{
    public static void Main(string[] args)
    {
        // x: 0 y: 0; z: 0;
        Vector defaultVector = new Vector();
        Console.WriteLine($"Default Constructor Vector: {defaultVector.ToString()}");

        // x: 25 y: 25; z: 25;
        Vector customVector = new Vector(25f, 25f, 25f);
        Console.WriteLine($"Custom Constructor Vector: {customVector.ToString()}");

        // x: 300; y: 300; z: 300;
        Vector addVec1 = new Vector(100f, 100f, 100f);
        Vector addVec2 = new Vector(200f, 200f, 200f);
        Console.WriteLine($"Addition: {addVec1 + addVec2}");
        
        // x: 50; y: 75; z: 75;
        Vector subVec1 = new Vector(100f, 100f, 100f);
        Vector subVec2= new Vector(50f, 25f, 25f);
        Console.WriteLine($"Subtraction: {subVec1 - subVec2}");
        
        // x: 1000; y: 1000; z: 1000;
        Vector mulVec = new Vector(100f, 100f, 100f);
        const float scalar = 10f;
        Console.WriteLine($"Multiplication: {subVec1 * scalar}");
        
        // Distance
        Vector distVec1 = new Vector(20f, 20f, 20f);
        Vector distVec2 = new Vector(50f, 50f, 50f);
        Console.WriteLine($"Distance: {distVec1.GetDistance(distVec2)}");
        
        // Magnitude
        Vector magVec = new Vector(1f, 2f, 3f);
        Console.WriteLine($"Magnitude: {magVec.GetMagnitude()}");
        
        // Square Magnitude
        Vector sqrMagVec = new Vector(100f, 100f, 100f);
        Console.WriteLine($"Square Magnitude: {sqrMagVec.GetSquareMagnitude()}");
    }
}