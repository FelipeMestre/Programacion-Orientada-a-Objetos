using System;
namespace Character
{
    class Character

        { 
            public Character(int vida, int daño, string poder, string nickname)
            {
                this.vida = vida;
                this.daño = daño;
                this.poder = poder;
                this.nickname = nickname;
            }
            public int vida {get;private set;}
            public int daño {get;}
            public string poder{get;}
            public string nickname{get;} 
            public void Atack (Character player)
            {    
                player.vida = player.vida - this.daño;
                Console.WriteLine(player.vida);
            }
        }
    class Probar
    {    
        static void Main()
        {
            Character personaje = new Character(100,20,"Patada baja","Charmander");
            Character personaje2 = new Character(100,20,"Patada baja","Bulbasaur");
            personaje.Atack(personaje2);
        }
    }
}