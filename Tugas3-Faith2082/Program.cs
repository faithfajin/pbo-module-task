namespace tugas3.faith2082
{

    class Processor //Parent Class//
    {
        public string merk, tipe;
    }


    class Intel : Processor //Child Class Processor//
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class CoreI3 : Intel //Child Class Intel//
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel //Child Class Intel//
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel //Child Class Intel//
    { 
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }


    class Amd : Processor //Child Class Processor//
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    class Ryzen : Amd   //Child Class Amd//
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class Athlon : Amd //Child Class Amd//
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }


    class Vga //Parent Class//
    {
        public string merk;
    }
    class Nvidia : Vga //Child Class Vga//
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga //Child Class Vga//
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    
    class Laptop //Parent Class//
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan() //Method//
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }

        public void LaptopDimatikan() //Method//
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }



    }

    class ASUS : Laptop //Child Class Laptop//
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    class Vivobook : ASUS //Child Class Asus//
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding() //Method//
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ROG : ASUS //Child Class Asus//
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }


    class ACER : Laptop //Child Class Laptop//
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    class Predator : ACER //Child Class ACER//
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame() //Method//
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Swift : ACER //Child Class ACER//
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Lenovo : Laptop //Child Class Laptop//
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo //Child Class Lenovo//
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo //Child Class Lenovo//
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soal Nomor 1");
            Laptop laptop2 = new IdeaPad();
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();


            //Console.WriteLine("Soal Nomor 2");
            //laptop laptop1 = new Vivobook();
            //laptop1.vga = new Nvidia();
            //laptop1.processor = new CoreI5();
            //laptop1.Ngoding();


            Console.WriteLine("Soal Nomor 3");
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();

            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);


            Console.WriteLine("Soal Nomor 4");
            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.processor = new CoreI7();
            predator.BermainGame();


            //Console.WriteLine("Soal Nomor 5");
            //ACER acer  = new Predator();
            //acer.BermainGame();

        }

    }
}