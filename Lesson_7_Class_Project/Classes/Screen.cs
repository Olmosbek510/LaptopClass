using Classes.Enums;

namespace Classes;

public class Screen
{
    public int size { set; get; }
    public string name { get; set; }
    public bool IsTouchScreen { get; set; }
    public int speed { get; set; }
    public EScreenType Type { get; set; }
    public decimal price { get; set;}
}
