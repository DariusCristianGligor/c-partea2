using System;

namespace ConsoleApp1
{

    class Masina
    {
        private readonly string serieSasiu;
        private int nrKm = 0;
        private readonly string marca;
        private readonly string model;
        private string combustibil;
        public Masina(string serieSasiu, string marca, string model)
        {
            this.serieSasiu = serieSasiu;
            this.marca = marca;
            this.model = model;
        }
        public Masina(string serieSasiu, string marca, string model, int nrKm, string combustibil) : this(serieSasiu, marca, model)
        {
            this.nrKm = nrKm;
            this.combustibil = combustibil;

        }
        public string Combustibil
        {
            set
            {
                this.combustibil = value;
            }
            get
            {

                return combustibil;
            }
        }
        public string NrKMVerificare => $"Masina a efectuat {nrKm} km.";
        public string addKmParcursi(int nrKmparcursi)
        {
            if (nrKmparcursi < 0)
            {
                return $"Nr de km nu poate sa fie negativ";

            }
            nrKm += nrKmparcursi;
            return $"Km au fost adaugati cu succes, iar masina dvs a efecutat: {nrKm} km.";


        }
        public override string ToString()
        {
            return $@"Serie masina:{serieSasiu};
Marca:{marca};
Model:{model};
NrKm:{nrKm};
Combustibil:{combustibil}";
        }
    }
    abstract class Animal
    {
        public abstract string poateSaZboare();
    }
    class Lebada : Animal
    {
        private int ani;
        public Lebada(int ani)
        {
            this.ani = ani;
        }
        public override string poateSaZboare()
        {
            return $"Poate sa zboare in orice conditii";
        }
    }
    class LebadaAurie : Lebada
    {
        public LebadaAurie(int ani2) : base(ani2)
        {

        }
        public string poateSaZboare()
        {
            return $"Poate sa zboare doar in conditii bune de vreme";
        }
    }
    interface Animal2
    {

        Boolean esteUnBunInotator();
    }

    class Iepure
    {
        private int ani;

        public Iepure(int ani)
        {
            this.ani = ani;
        }

    }

    class Concatenare {

        public string con1(string a)
        { return a; }
        public string con1(string a, string b)
        {
            return a + b;
        }
        public string con1(params string[] a)
        {
            string suma = "";
            foreach (string i in a)
            { suma += i;
            }
            return suma;
        }
    
    
    
    }



    class Program
    {
        static void Main(string[] args)
        {
            Masina m1 = new Masina("MRS1298", "Mercedes", "S");
            Console.WriteLine(m1);
            Masina m2 = new Masina("MRS1111298", "Mercedes", "CLS", 12332, "Benzina");
            Console.WriteLine(m2);
            m2.addKmParcursi(1234);
            Console.WriteLine(m2);
            Console.WriteLine(m2.NrKMVerificare);
            m1.Combustibil = "Benzina si Gaz";
            Console.WriteLine(m1);
            ////////////
            Lebada l = new Lebada(112);
            Console.WriteLine(l.poateSaZboare());
            Lebada la = new LebadaAurie(112);
            Console.WriteLine(la.poateSaZboare());
            //se foloseste fct din cls.Lebada
            LebadaAurie la2 = new LebadaAurie(12);
            Console.WriteLine(la2.poateSaZboare());
            //foloseste fct din lebadaaurie;
            Concatenare a = new Concatenare();
            Console.WriteLine(a.con1("Ana"));
            Console.WriteLine(a.con1("Ana ","are mere"));
            Console.WriteLine(a.con1("Ana ", "are mere", "si pere"));
        }
    }
}