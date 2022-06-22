using System;

namespace Composite
{
    class Unit: IArmy
    {
        public uint HP { get; set; }
        public uint Moves { get; set; }

        public void Fight(Unit unit)
        {
            if(Moves > 0)
            {
                Moves--;
                if(unit.HP > 1)
                {
                    unit.HP--;
                }
                else
                {
                    unit.HP = 0;
                    Console.WriteLine("Enemy is dead.");
                }
            }
            else
            {
                Console.WriteLine("No moves.");
            }
        }

        public void Move()
        {
            if(Moves > 0)
            {
                Moves--;
            }
            else
            {
                Console.WriteLine("No moves.");
            }
        }
    }
}
