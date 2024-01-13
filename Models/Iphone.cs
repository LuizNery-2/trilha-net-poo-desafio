namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {   
        public Iphone(string numero, string Modelo, string IMEI, int Memoria): base(numero, Modelo, IMEI,  Memoria){

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo: {nomeApp} no Iphone");
            Thread.Sleep(2000);
            Console.WriteLine($"{nomeApp} instaldo com sucesso");

        }
    }
}