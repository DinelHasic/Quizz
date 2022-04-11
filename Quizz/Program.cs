
using Quizz;

List<User> users = new List<User>()
{
    new Student("Dinel", "Hasic", "Dinko", "12223"),
    new Student("Tom", "Holand", "Tomy", "Programing1"),
    new Student("Eizabeth", "Yu", "El", "el123"),
    new Teacher("Profesor", "Harwy", "Harr", "3334",Subject.Geography)
};


int count = 0;
while (count < 3)
{
    User user = UserLogin();

    if (user != null)
    {
        if (user is Student student)
        {
            Quizz(student);
        }

        if (user is Teacher teacher)
        {
            TeacherLogsin(teacher);
        }
    }
    else
    {
        Console.WriteLine("Incorect Username or Password");
        count++;
        continue;
    }
    count = 0;
}

Console.ReadLine();

User UserLogin()
{
    Console.WriteLine("Log in");

    Console.Write("Enter Username:");
    string username = Console.ReadLine();

    Console.Write("Enter Password:");
    string password = Console.ReadLine();

    User user = users.FirstOrDefault(u => u.Username == username && u.GetPassword() == password);

    return user;
}

void TeacherLogsin(Teacher teacher)
{
    List<Student> students = users.Where(x => x is Student).Select(x => (Student)x).ToList();
    while (true)
    {
        Console.Clear();
        Console.WriteLine(teacher);
        Console.WriteLine("Students:");
        teacher.printStudents(students);
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Press enter to exit...");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) break;
    }
}

void Quizz(Student student)
{

    Console.WriteLine(student);

    if (student.Grade == 0)
    {
        int grade = 0;
        List<string> correctAnswears = new List<string>() { "b", "d", "c", "b", "b" };
        List<string> questions = new List<string>()
    {
        "1.Q: What is the capital of Tasmania ? \na: Dodoma \nb: Hobart \nc: Launceston \nd: Wellington",
        "2.Q: What is the tallest building in the Republic of the Congo ? \na: Kinshasa Democratic Republic of the Congo Temple \nb: Palais de la Nation \nc: Kongo Trade Centre \nd: Nabemba Tower *",
        "3.Q: Which of these is not one of Pluto's moons? \na: Styx \nb: Hydra \nc: Nix \nd: Lugia",
        "4.Q: What is the smallest lake in the world? \na: Onega Lake \nb: Benxi Lake \nc: Kivu Lake \nd: Wakatipu Lake",
        "5.Q: What country has the largest population of alpacas? \na: Chad \nb: Peru \nc: Australia \nd: Niger"
    };


        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine("Choose from a to b:");
            string answear = Console.ReadLine();
            if (correctAnswears[i] == answear) grade++;
        }

        if (grade == 0) grade = 1;

        student.Grade = grade;
        Console.WriteLine($"Your grade is {student.Grade}");
    }
    else
    {
        Console.WriteLine("You already took the test");
    }
}







