using EjercicioClase;

class Program
{
    public static void Main(string[] args)
    {
        SuperHeroe heroe1 = new SuperHeroe();
        heroe1.crearheroe("bruce", "batman", "gotica", "No");
        Console.WriteLine("Nombre: " + heroe1.Nombre);
        Console.WriteLine("ID secreta: " + heroe1.IdentidadSecreta);
        Console.WriteLine("Ciudad: " + heroe1.Ciudad);
        Console.WriteLine("Puede Volar?: " + heroe1.PuedeVolar);
        Superpoder superpoder1 = new Superpoder();
        superpoder1.crearpoder("RayosX", "Expulsa rayos cruzados por los ojos", "10");
        Console.WriteLine("Super Poder: " + superpoder1.Nombre);
        Console.WriteLine("Descripcion: "+ superpoder1.Descripcion);
        Console.WriteLine("Nivel: " + superpoder1.Nivel);
        Console.ReadLine();


    }
}