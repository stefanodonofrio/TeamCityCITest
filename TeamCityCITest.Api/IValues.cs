namespace TeamCityCITest.Api
{
    public interface IValues
    {
        public string Get();
    }

    public class Values : IValues
    {
        public string Get() => "Stefano";
        
    }
}
