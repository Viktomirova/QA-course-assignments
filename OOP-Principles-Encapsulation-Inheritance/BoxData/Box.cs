using System;
using System.Text;

namespace BoxData;

public class Box
{
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }
    public Box(double length, double width, double hight)
    {
        ValidateDimension(length, "Length");
        ValidateDimension(width, "Width");
        ValidateDimension(hight, "Height");
        Length = length;
        Width = width;
        Height = hight;
    }
    private void ValidateDimension(double dimension, string propertyName)
    {
        if (dimension <= 0)
        {
            throw new ArgumentException($"{propertyName} cannot be zero or negative.");
        }
    }

    public double SurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double Volume()
    {
        return Length * Width * Height;
    }

    public override string ToString()
    {
        return $"Surface Area - {SurfaceArea():F2}{Environment.NewLine}Volume - {Volume():F2}";
    }
}
