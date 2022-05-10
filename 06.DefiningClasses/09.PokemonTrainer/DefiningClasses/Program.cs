using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Trainer> trainers = new List<Trainer>();

            while((input=Console.ReadLine())!= "Tournament")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string trainerName = data[0];
                
                string pokemonName = data[1];
                string pokemonElement = data[2];
                int pokemonHealth = int.Parse(data[3]);
                bool existsTrainer = false;
                foreach (var tr in trainers)
                {
                    if (tr.Name.Equals(trainerName))
                    {
                        tr.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                        existsTrainer = true;
                       break;
                    }
                }
                if (!existsTrainer)
                {
                    Trainer trainer = new Trainer(trainerName);
                trainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                trainers.Add(trainer);
                }
                
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command.Equals("Fire"))
                {
                    foreach (var trainer in trainers)
                    {
                        bool hasPokemonElement = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element.Equals("Fire"))
                            {
                                hasPokemonElement = true;
                                trainer.NumberOfBadges++;
                                //not sure if I should add a badge for every pokemon
                                break;
                            }
                        }
                        if (!hasPokemonElement)
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health -= 10;
                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                }
                            }
                        }
                    }
                }
                else if (command.Equals("Water"))
                {
                    foreach (var trainer in trainers)
                    {
                        bool hasPokemonElement = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element.Equals("Water"))
                            {
                                hasPokemonElement = true;
                                trainer.NumberOfBadges++;
                                //not sure if I should add a badge for every pokemon
                                break;
                            }
                        }
                        if (!hasPokemonElement)
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health -= 10;
                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                }
                            }
                        }
                    }
                }
                else if(command.Equals("Electricity"))
                {
                    foreach (var trainer in trainers)
                    {
                        bool hasPokemonElement = false;
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element.Equals("Electricity"))
                            {
                                hasPokemonElement = true;
                                trainer.NumberOfBadges++;
                                //not sure if I should add a badge for every pokemon
                                break;
                            }
                        }
                        if (!hasPokemonElement)
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health -= 10;
                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                }
                            }
                        }
                    }
                }
            }
            trainers = trainers.OrderByDescending(x => x.NumberOfBadges).ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
