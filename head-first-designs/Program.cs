using System;
using head_first_designs.Features.Characters;
using head_first_designs.Features.Weapons;

namespace head_first_designs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myCharacter = new Warrior(new Hammer());
            var realProgram = new FightingCharacter(myCharacter);

            realProgram.DoSomeFightingStuff();
        }
    }

    public class FightingCharacter
    {
        // private - can only be used in this class
        private readonly Character _character;

        public FightingCharacter(Character character)
        {
            _character = character;
        }

        public void DoSomeFightingStuff()
        {
            Console.WriteLine(_character.Fight());
        }
    }
}
