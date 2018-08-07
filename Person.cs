namespace WebApplication1
{
    public interface IPerson
    {
        int Age { get; set; }
    }

    public class Person : IPerson
    {
        public Person()
        {

        }
        public int Age { get; set; }
    }
}
