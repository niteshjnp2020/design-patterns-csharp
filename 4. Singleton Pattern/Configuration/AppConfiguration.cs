public sealed class AppConfiguration
{
    private static readonly AppConfiguration _instance = new AppConfiguration();
    
    private AppConfiguration()
    {
        // Private constructor to prevent instantiation
    }

    public static AppConfiguration Instance
    {
        get
        {
            return _instance;
        }
    }


}