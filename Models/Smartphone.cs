namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo{get;}
        private string IMEI{get;}
        private int Memoria{get;}
    

        public Smartphone(string numero, string Modelo, string IMEI, int Memoria )
        {
            Numero = numero;
            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.Memoria =  Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}