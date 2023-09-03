Console.WriteLine("Ingrese la cantidad de llantas que desea comprar: ");
    int cantllantas = int.Parse(Console.ReadLine());

    decimal precioporllanta = (cantllantas >= 5) ? 700m : 800m;

    decimal total = cantllantas * precioporllanta;

Console.WriteLine("El total a pagar es: "+ total);
 
