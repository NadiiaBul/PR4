
namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Detachment detachment = new Detachment();
            detachment.Add(new Hydra { HP = 10, Moves = 25 });
            detachment.Add(new Hydra { HP = 10, Moves = 25 });

            Detachment detachment1 = new Detachment();
            detachment1.Add(new Centaur { HP = 15, Moves = 20});

            detachment.Add(detachment1);
            detachment.Add(new Dragon { HP = 8, Moves = 17 });

            Detachment detachment2 = new Detachment();
            detachment2.Add(detachment);
            detachment2.Add(new Orc { HP = 9, Moves = 11}); 

            Detachment detachment3 = new Detachment();
            detachment3.Add(new Cyclop { HP = 5, Moves = 12 });
            detachment3.Add(new Elf { HP = 17, Moves = 21 });
            detachment3.Add(new Minotaur { HP = 11, Moves = 16 });
            detachment3.Add(new Knight { HP = 18, Moves = 22 }); 
        }
    }
}
