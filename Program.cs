using Processor;
using Vga;

namespace Processor
{
    class Processor
    {
        public string merk;
        public string tipe;
        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }
    class Intel:Processor
    {
        public Intel(string tipe):base("Intel",tipe)
        { }
    }
    class AMD:Processor
    {
        public AMD(string tipe):base("AMD",tipe)
        { }
    }
    class CoreI3:Intel
    {
        public CoreI3():base("Core i3")
        { }
    }
    class CoreI5 : Intel
    {
        public CoreI5():base("Core i5")
        { }
    }
    class CoreI7:Intel
    {
        public CoreI7():base("Core i7")
        { }
    }
    class Ryzen:AMD
    {
        public Ryzen():base("RAYZEN")
        { }
    }
    class Athlon:AMD
    {
        public Athlon():base("ATHLON")
        { }
    }
}
namespace Vga
{
    class Vga
    {
        public string merk;
        public Vga(string merk)
        {
            this.merk = merk;
        }   
    }
    class Nvidia:Vga
    {
        public Nvidia():base("Nvidia")
        { }
    }
    class AMD:Vga
    {
        public AMD():base("AMD")
        { }
    }
}
namespace Laptop
{
    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga.Vga vga;
        public Processor.Processor processor;
        public Vga.Vga vga_spek { get; set; }
        public Processor.Processor processor_spek { get; set; }
        public Laptop(string merk, string tipe, Vga.Vga vga, Processor.Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    class Asus:Laptop
    {
        public Asus(string tipe):base("Asus",tipe,null,null)
        { }
    }
    class Acer:Laptop
    {
        public Acer(string tipe):base("Acer", tipe,null,null)
        { }
    }
    class Lenovo:Laptop
    {
        public Lenovo(string tipe):base("Lenovo",tipe,null,null)
        { }
    }
    class ROG:Asus
    {
        public ROG(Vga.Vga vga, Processor.Processor processor) :base("ROG")
        { }
    }
    class Vivobook:Asus
    {
        public Vivobook(Vga.Vga vga, Processor.Processor processor) :base("Vivobook")
        { }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class Swift:Acer
    {
        public Swift(Vga.Vga vga, Processor.Processor processor) :base("Swift")
        { }
    }
    class Predator:Acer
    {
        public Predator(Vga.Vga vga, Processor.Processor processor) :base("Predator")
        { }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Ideapad:Lenovo
    {
        public Ideapad(Vga.Vga vga, Processor.Processor processor):base("Ideapad")
        { }
    }
    class Legion:Lenovo
    {
        public Legion(Vga.Vga vga, Processor.Processor processor) :base("Legion")
        { }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Variabel
        Laptop.Vivobook laptop1 = new Laptop.Vivobook (new Vga.Nvidia(), new Processor.CoreI5());
        Laptop.Ideapad laptop2 = new Laptop.Ideapad(new Vga.AMD(), new Processor.Ryzen());
        Laptop.Predator predator = new Laptop.Predator(new Vga.AMD(), new Processor.CoreI7());
        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        Console.WriteLine("\nSoal 2");
        laptop1.Ngoding();
        Console.WriteLine("\nSoal 3");
        laptop1.vga_spek = new Nvidia();
        laptop1.processor_spek = new CoreI5();
        Console.WriteLine($"\nSpesifikasi Laptop 1 :\nVga : {laptop1.vga_spek.merk}\nMerk Processor : {laptop1.processor_spek.merk}\nTipe Processor : {laptop1.processor_spek.tipe}");
        Console.WriteLine("\nSoal 4");
        predator.BermainGame();
        Console.WriteLine("\nSoal 5");
        Laptop.Acer acer = new Laptop.Predator(new Vga.AMD(), new Processor.CoreI7());
        //acer.BermainGame();
    }
}