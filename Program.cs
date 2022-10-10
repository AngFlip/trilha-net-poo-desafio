using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia celNokia = new Nokia("12 34567-8900","XPTO22","I123456789",64);
Iphone celIphone = new Iphone("98 76543-2100","XPZ22O","I123454321",64);

Console.WriteLine($"O número do seu Nokia é " + celNokia.Numero);
celNokia.Ligar();
celNokia.InstalarAplicativo("Orkut");
celNokia.ExibirConfig();

Console.WriteLine($"O número do seu Iphone é " + celIphone.Numero);
celIphone.ReceberLigacao();
celIphone.InstalarAplicativo("MSN");
celIphone.ExibirConfig();