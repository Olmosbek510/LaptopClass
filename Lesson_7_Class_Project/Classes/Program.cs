using Classes;
using Classes.Enums;

var laptop = new Laptop();
var Mac = laptop.CreateMinimalInstance("Macbook Air", "Apple", ELaptopType.Office, EcolorType.Midnight, true);
Mac.printInfo();



