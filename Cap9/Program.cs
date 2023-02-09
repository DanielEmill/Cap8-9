/*1. Crear una estructura para guardar los
productos de una tienda.
*/
Ejercicio1();
Ejercicio3();
Ejercicio4();
void Ejercicio1(){
    System.Console.WriteLine("Registra tu producto: ");
    Productos producto = new Productos();
    producto.Nombre = "Audifonos";
    producto.Precio = 9.99;
    producto.Cantidad = 2;

    System.Console.WriteLine("Usted ha guardado el producto: " + producto.Nombre + " de precio: $" + producto.Precio);
    
}
/*3 Crear estructuras enlazadas para guardar
la información de una mascota y su
dueño.*/
void Ejercicio3(){
    System.Console.WriteLine("Registra tu Mascota: ");
    mascota mascota1 = new mascota();
    mascota1.Nombre = "Juan";
    mascota1.TipoMascota = "perro";
    mascota1.persona.Nombre = "Pedro";
    mascota1.persona.Nacionalidad = "Dominicano";
    System.Console.WriteLine("Su mascota ha sido registrado, sus info:");
    System.Console.WriteLine($"Nombre: {mascota1.Nombre} Tipo de mascota: {mascota1.TipoMascota} y su dueño es {mascota1.persona.Nombre} de nacionalidad {mascota1.persona.Nacionalidad}");
}

/*4 Crear una enumeración para los
diferentes tipos de neumáticos.*/
void Ejercicio4(){
    System.Console.WriteLine("Ingresa el neumatico: ");
    neumatico rueda = neumatico.deportivos;
    System.Console.WriteLine("Usted ha seleccionado el neumatico " + rueda);
}




//Estructura del ejercicio1
public struct Productos
{
    public String Nombre;
    public Double Precio;
    public int Cantidad;
}
//Estructura del ejercicio2
public struct Persona
{
    public String Nombre;
    public String Nacionalidad;
}
public struct mascota
{
    public String Nombre;
    public String TipoMascota;
    public Persona persona;
}
//Enum
public enum neumatico
{
    deportivos,
    Invierno,
    Sport
}


