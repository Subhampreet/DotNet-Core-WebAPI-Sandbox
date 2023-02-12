﻿namespace PokemonAPIApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
