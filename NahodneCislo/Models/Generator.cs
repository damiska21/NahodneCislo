namespace NahodneCislo.Models
{
    public class Generator
    {
        private readonly Random random = new Random();
        public int VratCislo()
        {
            return random.Next(100);
        }
        public int Umocni(int x)
        {
            return x * x;
        }
    }
}
