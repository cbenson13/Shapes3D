using Shapes;

namespace Shapes3D {

  public abstract class Shape3D {
    // Method for surface area
    public abstract double GetSurfaceArea();

    // Method for volume
    public abstract double GetVolume();
  }

class Cubiod : Shape3D
{
   public double depth;
   public double width;
  public double height;
   public Cubiod (double depth, double width, double height)
   {
  this.width = width;
  this.height = height;
   this.depth = depth;
    }
    override public double GetSurfaceArea()
    {
        return (this.width * this.height * 2) + (this.width * this.depth * 2) + (this.height * this.depth *2);
    }
    public override double GetVolume()
    {
      return (this.width * this.height * this.height);
    }
}
class Cube : Shape3D
  {
    public double depth;
    public double width;
    public double height;

    public Cube(double depth, double width, double height)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }
    public override double GetSurfaceArea()
    {
        return (this.width * this.height * 6);
    }
    public override double GetVolume()
    {
        return (this.width * this.height);
    }
  }
  class Cylinder : Shape3D
  {
    public double height;
    public double radius;
    public Cylinder(double height, double radius)
    {
        this.height = height;
        this.radius = radius;
    }
    public override double GetSurfaceArea()
    {
        return ((this.height * this.radius * Math.PI * 2) + (2 * Math.PI * (this.radius * this.radius)));
    }
    public override double GetVolume()
    {
        return (this.height * Math.PI * (this.radius * this.radius));
    }
   }
   class Sphere : Shape3D
   {
    public double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }
    public override double GetSurfaceArea()
    {
        return(4 * Math.PI * (this.radius * this.radius));
    }
    public override double GetVolume()
    {
        return ((4/3) * Math.PI * (this.radius * this.radius * this.radius));
    }
   }
   class Ngonal : Shape3D
   {
    public double height;
    public double sideLength;
    public double intFaces;

    public Ngonal (double height, double sideLength, double intFaces)
   {
    this.height = height;
    this.sideLength = sideLength;
    this.intFaces = intFaces;
   }
   public override double GetSurfaceArea()
   {
    return(this.height * this.sideLength);
   }
   public override double GetVolume()
   {
    return();
   }

  

  }
}
