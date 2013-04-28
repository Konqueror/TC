public class Size
{
    private double width;
    private double height;

    public Size(double width, double hight)
    {
        this.Width  = width;
        this.Height  = hight;
    }
}

public static Size GetRotatedSize(Size initialSize, double angleOfRotating)
{
    double CosWidthSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Width;
    double SinHeightSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Height;
    double SinWidthSize = Math.Abs(Math.Sin(angleOfRotating)) * initialSize.Width;
    double CosHeightSize = Math.Abs(Math.Cos(angleOfRotating)) * initialSize.Height;
    
    double fullWidthSize = CosWidthSize + SinWidthSize;
    double fullHeightSize = CosHeightSize + SinHeightSize;
    
    Size Size = new Size(fullWidthSize, fullHeightSize);
    return Size;
}
