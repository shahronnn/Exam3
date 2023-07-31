public class Circle
{
    double radius=1.0;
    string color="red";

    public Circle(){}
    public Circle(double radius)
    {
    }
    public Circle(double radius, string color)
    {
    }
    public double GetRadius()=> radius;
    public void SetRadius(double radius)=> this.radius=radius;
    public string GetColor()=> color;
    public void SetColor(string color)=> this.color=color;
    public string Tostring()=> $"radius = {radius} color = {color}";
    public double GetArea()=> 3.14*(radius*radius);
}