using Classes.Enums;

namespace Classes;

public class Laptop
{
   //Fields
   private string Name { get; set; } = null!;
   public string BrandName { get; set; } = String.Empty;
   public DateTime ReleaseDate { get; set; }
   public decimal Price { get; set; }
   public double weight { get; set; }
   public Ram Ram { get; set; }
   public ELaptopType Type { get; set; } = ELaptopType.Office;
   public Screen Screen { get; set; }
   public EcolorType Type1 { get; set; }
   public LaptopMemory Memory { get; set; }
   public bool IsNew { get; set; }
   public CPU Cpu { get; set; }
   public GPU Gpu { get; set; }

   public Laptop(){}
   public Laptop CreateMinimalInstance(string name, string b_name,ELaptopType type,EcolorType color,bool isnew)
   {
      return new Laptop()
      {
         Name = name,
         BrandName = b_name,
         Type = type,
         Type1 = color,
         IsNew = isnew
      };
   }
   public void printInfo()
   {
      Console.WriteLine("Name: {0}",Name);
      Console.WriteLine("Brand name: {0} ",BrandName);
      Console.WriteLine("Type: {0}",Type);
      Console.WriteLine("Colour: {0}",Type1);
      Console.WriteLine("IsNew: {0}",IsNew);
   }
}


