
namespace SOLID_Liskov
{
    public class Program
    {
        static void MakeAllFly(List<IFlyable> flyables)
        {
            foreach (var f in flyables)
                f.Fly();
        }

        static void Main()
        {
            var flyables = new List<IFlyable>
        {
            new Eagle()
           
        };

            MakeAllFly(flyables);

            Bird p = new Penguin(); 
            p.Eat();
        }
    }
    //static void MakeAllBirdsFly(List<Bird> birds)
    //{
    //    foreach (var b in birds)
    //        b.Fly();
    //}

    //static void Main()
    //{
    //    var birds = new List<Bird>
    //{
    //    new Eagle(),
    //    new Penguin()
    //};

    //    MakeAllBirdsFly(birds);
    //}
}



