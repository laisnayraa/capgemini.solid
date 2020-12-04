using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fruta fruta = new Laranja();
        Debug.WriteLine(fruta.GetCor());
        fruta = new Maca();
        Debug.WriteLine(fruta.GetCor());
    }
}
public abstract class Fruta
{
    public abstract string GetCor();
}
public class Maca : Fruta
{
    public override string GetCor()
    {
        return "Red";
    }
}
public class Laranja : Fruta
{
    public override string GetCor()
    {
        return "Laranja";
    }
}