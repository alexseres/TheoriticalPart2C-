namespace Tutorial10Interfaces
{
    public class TvRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Televison();
            
        }
    }
}