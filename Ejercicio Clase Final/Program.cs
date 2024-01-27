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

        Console.WriteLine("");

        SuperHeroe heroe2 = new SuperHeroe();
        heroe2.crearheroe("Steve", "Capitan America", "Bruklin", "No");
        Console.WriteLine("Nombre: " + heroe2.Nombre);
        Console.WriteLine("ID secreta: " + heroe2.IdentidadSecreta);
        Console.WriteLine("Ciudad: " + heroe2.Ciudad);
        Console.WriteLine("Puede Volar?: " + heroe2.PuedeVolar);
        Superpoder superpoder2 = new Superpoder();
        superpoder2.crearpoder("super fuerte", "Tiene un escudo", "10");
        Console.WriteLine("Super Poder: " + superpoder2.Nombre);
        Console.WriteLine("Descripcion: " + superpoder2.Descripcion);
        Console.WriteLine("Nivel: " + superpoder2.Nivel);

        Console.WriteLine("");

        SuperHeroe heroe3 = new SuperHeroe();
        heroe3.crearheroe("Tony Stark", "IroMan", "U.S.A", "Si");
        Console.WriteLine("Nombre: " + heroe3.Nombre);
        Console.WriteLine("ID secreta: " + heroe3.IdentidadSecreta);
        Console.WriteLine("Ciudad: " + heroe3.Ciudad);
        Console.WriteLine("Puede Volar?: " + heroe3.PuedeVolar);
        Superpoder superpoder3 = new Superpoder();
        superpoder3.crearpoder("Es millonario e Inteligente", "Un super traje", "10");
        Console.WriteLine("Super Poder: " + superpoder3.Nombre);
        Console.WriteLine("Descripcion: " + superpoder3.Descripcion);
        Console.WriteLine("Nivel: " + superpoder3.Nivel);

        Console.ReadLine();

    }
}