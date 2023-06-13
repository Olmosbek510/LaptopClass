namespace Classes;

public class Calculator
{
   public int Add(params int[] sonlar)
   {
      if (sonlar.Length == 0 ) throw new Exception("At least one integer have to be entered");
      return sonlar.Sum();
   }
   public double Add(params double[] sonlar)
   {
      if(sonlar.Length==0) throw new Exception("At least one integer have to be entered");
      return sonlar.Sum();
   }
   
   //properties
   
   //-public  
   public int publicField;
   
   //-private
   private string modelName;
   
   //protected

   protected string Family;
}

class child : Calculator
{
    Calculator fall = new Calculator();
}