    Console.WriteLine("--------------------------------------");
    Console.WriteLine("| Bienvenue dans le NOMBRE MAGIQUE ! |");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("|   Touver le nombre entre 1 et 10   |");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("");
    
    Random aleatoire = new Random();
    int nombreMagique = aleatoire.Next(1, 11);
    
    int life = 5;
    
    DemanderNombre(nombreMagique,life);



static int DemanderNombre(int nombreMagique, int life)
{
    int number = 0;
    
    while (number <= 0 || number > 10)
    {

        Console.WriteLine($"Point de vie : {life}");
        Console.WriteLine("");
        Console.Write("Réponse : ");
        string number_str = Console.ReadLine();

        try
        {
            number = int.Parse(number_str);
            if (number >= 11)
                Console.WriteLine("Erreur : Le nombre ne doit pas être superieur à 10");
            if (number < 0)
                Console.WriteLine("Erreur : Le nombre ne doit pas être négatif");
            if (number == 0)
                Console.WriteLine("Erreur: Le nombre ne doit pas être égal à 0");
        }
        catch
        {
            Console.WriteLine("Erreur :  Vous devez rentrer un nombre valide.");
        }
    }

    return ReponseNombre(nombreMagique, number, life);
}


static int ReponseNombre(int nombreMagique, int number, int life)
{
    if (life == 1)
    {
        Console.WriteLine($"Vous avez perdu, le chiffre magique était le  : {nombreMagique}");
        return life;
    }
    if (number == nombreMagique)
    {
        Console.WriteLine($"Bien Jouer vous avez trouver le nombre Magique qui est le : {nombreMagique} !");
    }
    if (number > nombreMagique)
    {
        Console.WriteLine("le nombre Magique est plus petit.");
        life = life -1;
        return DemanderNombre(nombreMagique, life);
    }

    if (number < nombreMagique)
    {
        Console.WriteLine("le nombre Magique est plus grand.");
        life = life -1;
        return DemanderNombre(nombreMagique, life);
    }

    return number;
}
