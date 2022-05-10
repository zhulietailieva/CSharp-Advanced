using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }
    }

}
