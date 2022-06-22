using System.Collections.Generic;

namespace Composite
{
    class Detachment : IArmy
    {
        private readonly List<IArmy> _armies = new List<IArmy>();
        public void Add(IArmy army)
        {
            _armies.Add(army);
        }
        public void Fight(Unit unit)
        {
            foreach (var x in _armies)
            {
                x.Fight(unit);
            }
        }

        public void Move()
        {
            foreach(var y in _armies)
            {
                y.Move();
            }
        }
    }
}
