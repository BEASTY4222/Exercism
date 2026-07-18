using System.Drawing;

public static class Triangle
{
    private static bool isTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side3 + side2 > side1 && side3 + side1 > side2 &&
        (side1 > 0d && side2 > 0d && side3 > 0);
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        if(!isTriangle(side1,side2,side3)) return false;

        return side1 != side2 && side1 != side3 &&
                side2 != side3;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if(!isTriangle(side1,side2,side3)) return false;

        return (side1 == side2 && side1 != side3 &&side2 != side3) || 
                (side1 != side2 && side1 == side3 && side2 != side3) || 
                (side1 != side2 && side1 != side3 && side2 == side3) || IsEquilateral(side1,side2,side3);
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        if(!isTriangle(side1,side2,side3)) return false;
        
        return side1 == side2 && side1 == side3 &&
                side2 == side3;
    }
}