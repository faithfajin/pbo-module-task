namespace tugas3.faith2082
{

    class Processor
    {
        public string merk, tipe;
    }


    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }


    class Amd : Processor
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    class Ryzen : Amd   
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class Athlon : Amd
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }


    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }


    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }



    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }


    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
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