
namespace Composite
{
    class Dragon : Unit
    {
        public void Flight(Unit unit)
        {
            Moves += 10;
            Fight(unit);
        }
    }
}
