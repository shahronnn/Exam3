public class Cylinder: Circle
{
    double height=1.0;

    public Cylinder(){}
    public Cylinder(double height){}
    public Cylinder(double height, double radius){}
    public Cylinder(double height, double radius, string color){}
    public double GetHeight()=> height;
    public void SetHeight(double height)=> this.height=height;
    public string Tostring()=> GetColor();
    public double GetVolume()=> 3.14*(GetRadius()*GetRadius())*height;
}