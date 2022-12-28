using System.Text.Json.Serialization;

namespace AjaxExp.Models;

public class Box
{
    [JsonPropertyName("BoxName")]
    public string BoxName { get; set; }

    [JsonPropertyName("Width")]
    public int Width { get; set; }

    [JsonPropertyName("Length")]
    public int Length { get; set; }

    [JsonPropertyName("Height")]
    public int Height { get; set; }

    public Box(
        string boxName,
        int width,
        int length,
        int height)
    {
        BoxName = boxName;
        Width = width;
        Length = length;
        Height = height;
    }

    public Box()
    {
        BoxName = "Default Box";
        Width = 1;
        Length = 1;
        Height = 1;
    }
}

public static class BoxStatic
{
    public static readonly List<Box> Boxes =

        new()
        {
            new("Tiny Box", 10, 20, 10),
            new("Small Box", 15, 25, 15),
            new("Standard Box", 20, 30, 20),
            new("Large Box", 30, 40, 30),
            new("Gigantic Box", 100, 200, 100)
        };
}