using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasBangunDatar
{
    public abstract class Shape // Base Class (parent)
    {

        public Shape() //constructor
        {

        }

        public virtual void getArea() //polimorphism
        {

        }

        public virtual void getKeliling() //polimorphism
        {

        }
    }

    public class Square : Shape // Derived class (child)
    {
        protected double firstSide;
        protected double secondSide;
        protected double Luas;
        protected double Keliling;

        public Square(double sisi1, double sisi2) //constructor
        {
            this.firstSide = sisi1;
            this.secondSide = sisi2;
        }

        public Square(double sisi) // overloading constructor
        {
            this.firstSide = sisi;
        }

        public override void getArea() //@override
        {
            this.Luas = firstSide * secondSide;
            Console.WriteLine("Area : " + Luas);
        }

        public override void getKeliling()
        {
            this.Keliling = 4 * firstSide;
            Console.WriteLine("Keliling : " + Keliling);
        }
    }

    public class Rect : Shape // Derived class (child)
    {
        protected double panjang;
        protected double lebar;
        protected double Luas;
        protected double Keliling;

        public Rect(double p, double l) //constructor
        {
            this.panjang = p;
            this.lebar = l;
        }

        public override void getArea() //@override
        {
            this.Luas = panjang * lebar;
            Console.WriteLine("Area : " + Luas);
        }

        public override void getKeliling()
        {
            this.Keliling = 2 * (panjang + lebar);
            Console.WriteLine("Keliling : " + Keliling);
        }
    }

    public class Dimentional : Shape //Derived class (child)
    {
        protected double alas;
        protected double tinggi;
        protected int bawah;
        protected double Luas;
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;
        protected double Keliling;

        public Dimentional(double a, double t) //constructor
        {
            this.alas = a;
            this.tinggi = t;
        }

        public Dimentional(double s1, double s2, double s3) //overload constructor keliling segitiga
        {
            this.firstSide = s1;
            this.secondSide = s2;
            this.thirdSide = s3;
        }

        public Dimentional(double a, int b) //overload constructor keliling jajargenjang
        {
            this.alas = a;
            this.bawah = b;
        }
        public override void getArea() //@override triangle
        {
            this.Luas = (alas * tinggi) / 2;
            Console.WriteLine("Area : " + Luas);
        }

        public override void getKeliling() //@override triangle
        {
            this.Keliling = secondSide + secondSide + thirdSide;
            Console.WriteLine("Keliling : " + Keliling);
        }
        public void getAreaParallelogram()
        {
            this.Luas = alas * tinggi;
            Console.WriteLine("Area : " + Luas);
        }

        public void getKelilingParallelogram() //keliling jajar genjang
        {
            this.Keliling = 2 * (alas + bawah);
            Console.WriteLine("Keliling : " + Keliling);
        }
    }

    public class Trapezoid : Shape //Derived class (child)
    {
        protected double alas;
        protected double tinggi;
        protected double bawah;
        protected double Luas;
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;
        protected double forthSide;
        protected double Keliling;

        public Trapezoid(double a, double t, double b) //constructor
        {
            this.alas = a;
            this.tinggi = t;
            this.bawah = b;
        }

        public Trapezoid(double s1, double s2, double s3, double s4) //constructor
        {
            this.firstSide = s1;
            this.secondSide = s2;
            this.thirdSide = s3;
            this.forthSide = s4;
        }

        public override void getArea() // @override
        {
            this.Luas = ((alas + bawah) * tinggi) / 2;
            Console.WriteLine("Area : " + Luas);
        }

        public override void getKeliling() //keliling trapesium
        {
            this.Keliling = firstSide + secondSide + thirdSide + forthSide;
            Console.WriteLine("Keliling : " + Keliling);
        }
    }
    class Program
    {
        static void menuArea()
        {
            Console.WriteLine("Input Your Number From 1-5");
            Console.WriteLine("1. Square Area");
            Console.WriteLine("2. Rect Area");
            Console.WriteLine("3. Triangle Area");
            Console.WriteLine("4. Parallelogram Area");
            Console.WriteLine("5. Trapezoid Area");
            Console.WriteLine("");
            String option = Console.ReadLine();
            int menu = Convert.ToInt32(option);

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Square Area");
                    Console.Write("Input first side : ");
                    String firstSide = Console.ReadLine();
                    Console.Write("Input second side : ");
                    String secondSide = Console.ReadLine();

                    double sisi1 = Convert.ToDouble(firstSide);
                    double sisi2 = Convert.ToInt32(secondSide);
                    Square persegi = new Square(sisi1, sisi2);
                    persegi.getArea();
                    break;

                case 2:
                    Console.WriteLine("Rect Area");
                    Console.Write("Input long side : ");
                    string panjang = Console.ReadLine();
                    Console.Write("Input wide side : ");
                    string lebar = Console.ReadLine();

                    double p = Convert.ToDouble(panjang);
                    double l = Convert.ToDouble(lebar);
                    Rect persegiPanjang = new Rect(p, l);
                    persegiPanjang.getArea();
                    break;

                case 3:
                    Console.WriteLine("Triangle Area");
                    Console.Write("Input a side : ");
                    string alas = Console.ReadLine();
                    Console.Write("Input t side : ");
                    string tinggi = Console.ReadLine();

                    double a = Convert.ToDouble(alas);
                    double t = Convert.ToDouble(tinggi);
                    Dimentional segitiga = new Dimentional(a, t);
                    segitiga.getArea();
                    break;
                case 4:
                    Console.WriteLine("Parallelogram Area");
                    Console.Write("Input a side : ");
                    alas = Console.ReadLine();
                    Console.Write("Input t side : ");
                    tinggi = Console.ReadLine();

                    a = Convert.ToDouble(alas);
                    t = Convert.ToDouble(tinggi);
                    Dimentional jajarGenjang = new Dimentional(a, t);
                    jajarGenjang.getAreaParallelogram();
                    break;
                case 5:
                    Console.WriteLine("Trapezoid Area");
                    Console.Write("Input a side : ");
                    alas = Console.ReadLine();
                    Console.Write("Input b side : ");
                    string bawah = Console.ReadLine();
                    Console.Write("Input t side : ");
                    tinggi = Console.ReadLine();

                    a = Convert.ToDouble(alas);
                    t = Convert.ToDouble(tinggi);
                    double b = Convert.ToDouble(bawah);
                    Trapezoid trapesium = new Trapezoid(a, t, b);
                    trapesium.getArea();
                    break;
                default:
                    Console.WriteLine("Please Input Number 1-5");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Type yes to restart program");
            String restart = Console.ReadLine();
            if (restart.ToLower() == "yes")
            {
                Menu();
            }
        }

        static void menuKeliling()
        {
            Console.WriteLine("Input Your Number From 1-5");
            Console.WriteLine("1. Keliling Persegi");
            Console.WriteLine("2. Keliling Persegi Panjang");
            Console.WriteLine("3. Keliling Segitiga");
            Console.WriteLine("4. Keliling Jajargenjang");
            Console.WriteLine("5. Keliling Trapesium");
            Console.WriteLine("");
            String option = Console.ReadLine();
            int menu = Convert.ToInt32(option);

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Keliling Persegi");
                    Console.WriteLine("Masukan sisi : ");
                    String firstSide = Console.ReadLine();

                    double sisi = Convert.ToDouble(firstSide);
                    Square kelPersegi = new Square(sisi);
                    kelPersegi.getKeliling();
                    break;
                case 2:
                    Console.WriteLine("Keliling Persegi Panjang");
                    Console.Write("Masukan panjang : ");
                    string panjang = Console.ReadLine();
                    Console.Write("Masukan lebar : ");
                    string lebar = Console.ReadLine();

                    double p = Convert.ToDouble(panjang);
                    double l = Convert.ToDouble(lebar);
                    Rect kelPersegiPanjang = new Rect(p, l);
                    kelPersegiPanjang.getKeliling();
                    break;
                case 3:
                    Console.WriteLine("Keliling Segitiga");
                    Console.Write("Masukan sisi ke 1 : ");
                    firstSide = Console.ReadLine();
                    Console.Write("Masukan sisi ke 2 : ");
                    String secondSide = Console.ReadLine();
                    Console.Write("Masukan sisi ke 3 : ");
                    String thirdSide = Console.ReadLine();

                    double s1 = Convert.ToDouble(firstSide);
                    double s2 = Convert.ToDouble(secondSide);
                    double s3 = Convert.ToDouble(thirdSide);
                    Dimentional kelSegitiga = new Dimentional(s1, s2, s3);
                    kelSegitiga.getKeliling();
                    break;
                case 4:
                    Console.WriteLine("Keliling Jajargenjang");
                    Console.Write("Masukan sisi a : ");
                    string alas = Console.ReadLine();
                    Console.Write("Masukan sisi b : ");
                    string bawah = Console.ReadLine();

                    double a = Convert.ToDouble(alas);
                    int b = Convert.ToInt32(bawah);
                    Dimentional kelJajargenjang = new Dimentional(a, b);
                    kelJajargenjang.getKelilingParallelogram();
                    break;
                case 5:
                    Console.WriteLine("Keliling Trapesium");
                    Console.Write("Masukan sisi ke 1 : ");
                    firstSide = Console.ReadLine();
                    Console.Write("Masukan sisi ke 2 : ");
                    secondSide = Console.ReadLine();
                    Console.Write("Masukan sisi ke 3 : ");
                    thirdSide = Console.ReadLine();
                    Console.Write("Masukan sisi ke 4 : ");
                    String forthSide = Console.ReadLine();

                    s1 = Convert.ToDouble(firstSide);
                    s2 = Convert.ToDouble(secondSide);
                    s3 = Convert.ToDouble(thirdSide);
                    double s4 = Convert.ToDouble(forthSide);
                    Trapezoid kelTrapesium = new Trapezoid(s1, s2, s3, s4);
                    kelTrapesium.getKeliling();
                    break;
                default:
                    Console.WriteLine("Please Input Number 1-5");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Type yes to restart program");
            String restart = Console.ReadLine();
            if (restart.ToLower() == "yes")
            {
                Menu();
            }
        }
        static void Menu()
        {
            Console.WriteLine("Input Your Number 1 or 2");
            Console.WriteLine("1. Luas Bangun Datar");
            Console.WriteLine("2. Keliling Bangun Datar");
            Console.WriteLine("");
            String option = Console.ReadLine();
            int menu = Convert.ToInt32(option);

            if (menu == 1)
            {
                menuArea();
            }
            else if (menu == 2)
            {
                menuKeliling();
            } else
                Console.WriteLine("Please Input Number 1 or 2");
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}