namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Play Store: Instalando {nomeApp}...10%");
            Console.WriteLine($"Play Store: Instalando {nomeApp}...50%");
            Console.WriteLine($"Play Store: Instalando {nomeApp}...100%");
        }
    }
}