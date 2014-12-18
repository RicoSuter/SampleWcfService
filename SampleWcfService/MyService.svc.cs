namespace SampleWcfService
{
    public class MyService : IMyService
    {
        public int Sum(int a, int b)
        {
            return a + b; 
        }
    }
}
