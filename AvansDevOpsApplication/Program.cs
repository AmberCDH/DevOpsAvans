// See https://aka.ms/new-console-template for more information
using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.Composite;
using AvansDevOpsApplication.Domain.Factory;

public class Program
{
    private static void Main(string[] args)
    {
        var localDate = DateTime.Now;
        var birthday = new DateOnly(2000, 1, 12);
        var user = new User("Tom", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER);
        Console.WriteLine(user.toString());
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

        user.Name = "Test";
        Console.WriteLine(user.toString());
        user.Role = RoleType.SCRUM_MASTER;

        Console.WriteLine(user.toString());

        var activity = new Activity("help", "done", "not done", localDate);
        Console.WriteLine(activity.toString());

        var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, localDate, "Backlog");
        Console.WriteLine(backlogItem.toString());
        backlogItem.AddActivityToList(activity);
        Console.WriteLine(backlogItem.toString());

        // Composite
        List<ForumComponent> reactionsUS1 = [new Reactions("Niemand gebruikt dit", localDate, user)];
        List<ForumComponent> reactionsUS2 = [new Reactions("Ik ga huilen hoor", localDate, user), new Reactions("...", localDate, user)];

        ForumComponent FirstUserStory = new Forum(backlogItem);
        FirstUserStory.Add(new Post("Waar is de rest van dit item?", "US is onduidelijk", localDate, user, reactionsUS1));

        FirstUserStory.Add(new Post("Help?", "US is onduidelijk", localDate, user, reactionsUS2));

        FirstUserStory.Print();

        // Factory export1
        List<User> users = new List<User>();
        users.Add(user);
        Report report = new Report();
        report.createExport("pdf").exportReport("hey", "bye", users);
        Console.WriteLine(report.createExport("png"));
        Console.WriteLine(report.createExport(""));

        Console.ReadLine();
    }
}