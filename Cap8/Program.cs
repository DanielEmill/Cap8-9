/*3 Hacer un programa que muestre la hora del día en formato AM/FM seguida del año, el día y el mes actual.
5 Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.*/
System.Console.WriteLine("Ejercicio 3: Hora:");
Ejercicio3();
System.Console.WriteLine("Ejercicio 5: Orden:");
Ejercicio5();

void Ejercicio3(){
    DateTime Fecha = DateTime.Now;
    System.Console.WriteLine($"Hora: {Fecha.ToString("h:m tt")}:{Fecha.Year}");
}
void Ejercicio5(){
    System.Console.WriteLine("Ingrese la primera cadena: ");
    String Cadena1 = Console.ReadLine();
    System.Console.WriteLine("Ingrese la segunda cadena: ");
    String Cadena2 = Console.ReadLine();

    int Comparacion = String.Compare(Cadena1, Cadena2);
    Comparacion = 0;

    if(Comparacion < 0){
        System.Console.WriteLine("Orden orden alfabético");
        System.Console.WriteLine(Cadena1);
        System.Console.WriteLine(Cadena2);
    }
    else{
        System.Console.WriteLine(Cadena2);
        System.Console.WriteLine(Cadena1);
    }
}
