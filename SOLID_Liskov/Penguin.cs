
 
namespace SOLID_Liskov
{  
    public class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }       

    }

}
//public override void Fly()
        //{
        //    throw new NotSupportedException("Penguin can't fly!");
        //}