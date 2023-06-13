using Classes.Enums;

namespace Classes;

public class Ram
{
   public string Name { get; set; }
   public int size { get; set; }
   public string BrandName { get; set; }
   public DateOnly ReleaseDate { get; set; }
   public decimal price { get; set; }
   public ERamType Type
   {
      get;
      set;
   }
}