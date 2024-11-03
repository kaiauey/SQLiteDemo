using SQLiteDemo.Repositories;
namespace SQLiteDemo;

public partial class App : Application
{
	public static StudentRepository _studentRepo {get ; set;}
	public App(StudentRepository studentRepo)
	{
		InitializeComponent();
		_studentRepo = studentRepo;

		//MainPage = new AppShell();
		MainPage = new StudentPage();
	}
}
