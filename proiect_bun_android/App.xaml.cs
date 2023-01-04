using proiect_bun_android.Views;
using proiect_bun_android.DataBase;


namespace proiect_bun_android;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new LoginPage();
    }
    static LoginDatabase database;
    public static LoginDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
            return database;
        }
    }
}