namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {   
        public Nokia(string numero, string Modelo, string IMEI, int Memoria) : base(numero, Modelo, IMEI,Memoria){

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo: {nomeApp} no Nokia");
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeApp} instaldo com sucesso");
        }
    }
}