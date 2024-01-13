using DesafioPOO.Models;

Nokia nokia1 = new Nokia("(33) 9875-9654", "Nokia G42", "352069110084190", 256);
Nokia nokia2 = new Nokia("(81) 9889-7852", "Nokia Tijolão", "307575960624956", 2);

Iphone iphone1 = new Iphone("(13) 3011-6035", "iPhone 7s", "917260449280215", 64);
Iphone iphone2 = new Iphone("(14) 3874-6108", "iPhone Xs MAX", "502161739107418", 256);

iphone1.InstalarAplicativo("Instagram");
iphone2.InstalarAplicativo("Tiktok");
nokia1.InstalarAplicativo("Netflix");
nokia2.InstalarAplicativo("Subway Sufers");

Console.WriteLine(nokia1.Numero);
nokia1.ReceberLigacao();

Console.WriteLine(iphone1.Numero);
iphone1.ReceberLigacao();

Console.WriteLine(nokia2.Numero);
nokia2.ReceberLigacao();

Console.WriteLine(iphone2.Numero);
iphone2.ReceberLigacao();