namespace DesktopDependencyInjectionSample.UI
{
    public class Greeter : IGreeter
    {
        public string Greet(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
