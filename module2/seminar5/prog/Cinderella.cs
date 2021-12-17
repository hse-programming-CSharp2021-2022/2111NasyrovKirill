

namespace Cinderella
{
    public abstract class Something
    {
         
    }

    public class Lentil : Something
    {
        public double Weight;

        public override string ToString() => $"Lentil with weight {Weight}";
    }

    public class Ashes : Something
    {
        public double Volume;

        public override string ToString() => $"Ashes with volume {Volume}";
    }
}