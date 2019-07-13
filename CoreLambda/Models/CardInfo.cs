using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLambda.Models
{
    public class CardInfo
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string CardName { get; set; }
        public int Elixir { get; set; }
        public string CardType { get; set; }
        public string Travels { get; set; }
        public string Targets { get; set; }
        public string AttackAir { get; set; }
        public string Spawner { get; set; }
        public int RangeLevel { get; set; }
    }
}
