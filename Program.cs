// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;


public static class Saver
{
  public static void Save(object jsonData)
  {
    File.WriteAllText("./data.json", JsonSerializer.Serialize(jsonData));
  }
}
public class Point
{
  public double x { get; set; }
  public double y { get; set; }

}
namespace ConsoleApp
{
  class Program
  {

    static void Main()
    {
      int length = 12;
      double r = 400;
      double cx = 500;
      double cy = 500;

      // tablica ze współrzędnymi
      Point[] points = new Point[length];

      for (int i = 0; i < length; i++)
      {
        // Położenie punktu na okręgu r o środku cx,cy
        points[i] = new Point { x = Math.Round(cx + r * Math.Cos(((2 * Math.PI) / length) * i)), y = Math.Round(cy + r * Math.Sin(((2 * Math.PI) / length) * i)) };

      }

      // zapis do pliku
      Saver.Save(points);
    }
  }
}