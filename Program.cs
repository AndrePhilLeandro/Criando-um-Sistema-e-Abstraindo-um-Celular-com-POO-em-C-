using System;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static void Main(string[] args)
    {
        string n, m, i;
        int me;

        Console.Write("Digite o numero: ");
        n = Console.ReadLine();
        Console.Write("Digite o modelo : ");
        m = Console.ReadLine();
        Console.Write("Digite o IMEI : ");
        i = Console.ReadLine();
        Console.Write("Digite a quantidade de memoria : ");
        me = int.Parse(Console.ReadLine());

        /* NOKIA*/

        Nokia N1 = new Nokia(m);
        N1.numero = n;
        N1.imei = i;
        N1.memoria = me;
        Console.Write($"Smarthphone: {N1.modelo}, Numero: {N1.numero}, IMEI: {N1.imei}, Memoria: {N1.memoria}\n");
        N1.Ligar();
        N1.ReceberLigacao();
        Console.Write("Qual app deseja instalar?");
        string nome = Console.ReadLine();
        N1.InstalarAplicativos(nome);

        /* IPHONE*/
        Console.Write("Digite o numero: ");
        n = Console.ReadLine();
        Console.Write("Digite o modelo : ");
        m = Console.ReadLine();
        Console.Write("Digite o IMEI : ");
        i = Console.ReadLine();
        Console.Write("Digite a quantidade de memoria : ");
        me = int.Parse(Console.ReadLine());

        Iphone I1 = new Iphone(m);
        I1.numero = n;
        I1.imei = i;
        I1.memoria = me;


        Console.Write($"Smarthphone: {I1.modelo}, Numero: {I1.numero}, IMEI: {I1.imei}, Memoria: {I1.memoria}\n");
        I1.Ligar();
        I1.ReceberLigacao();
        Console.Write("Qual app deseja instalar?");
        nome = Console.ReadLine();
        I1.InstalarAplicativos(nome);

    }
    abstract class Smartphone
    {
        private string Numero;
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public string numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }
        public string imei
        {
            get { return IMEI; }
            set { IMEI = value; }
        }
        public int memoria
        {
            get { return Memoria; }
            set { Memoria = value; }
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");

        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação...");
        }
        public abstract void InstalarAplicativos(string nome);
        public Smartphone(string nome)
        {
            this.Modelo = nome;
        }
    }

    class Nokia : Smartphone
    {
        public Nokia(string nome) : base(nome)
        {
        }
        public override void InstalarAplicativos(string nome)
        {
            Console.WriteLine($"Instalando {nome}");
        }

    }
    class Iphone : Smartphone
    {
        public Iphone(string nome) : base(nome)
        {
        }
        public override void InstalarAplicativos(string nome)
        {
            Console.WriteLine($"Instalando {nome}");
        }

    }

}