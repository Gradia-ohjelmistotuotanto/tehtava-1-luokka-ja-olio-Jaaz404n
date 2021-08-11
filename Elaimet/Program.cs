using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luot luokasta olion
            Hevonen hevonen = new Hevonen();

            //Tulosta olion nimi ja paino
            Console.WriteLine("Nimi: " + hevonen.Nimi);
            Console.WriteLine("Paino: " + hevonen.Paino);

            //Muuta olion nimeä ja painoa
            hevonen.Nimi = "Histamiini";
            hevonen.Paino = 89;

            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine("Uusi nimi: " + hevonen.Nimi);
            Console.WriteLine("Uusi paino: " + hevonen.Paino);
        }
    }
}
