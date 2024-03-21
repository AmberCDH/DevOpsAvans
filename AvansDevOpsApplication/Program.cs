using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.Composite;
using AvansDevOpsApplication.Domain.Factory;
using AvansDevOpsApplication.Domain.Observer;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;



Composite();
GenerateBurnDownChart();
UserRoles();
ExportPDF();

static void GenerateBurnDownChart()
{
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, DateTime.Now, "Backlog");
    var sprint = new Sprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(4));
    sprint.AddBacklogItem(backlogItem);
    BurndownChart.Generate(sprint);
}

static void ExportPDF()
{
    var localDate = DateTime.Now;
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, localDate, "Backlog");
    var birthday = new DateTime(2000, 1, 12);
    var notificationService = new EmailObserver();
    var user = new User("Tom", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER, notificationService);
    var user1 = new User("Tristan", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER, notificationService);

    List<User> users = [user, user1];
    Report report = new Report();
    report.createExport("pdf").exportReport("hey", "bye", users);
    Console.WriteLine(report.createExport("png"));
    Console.WriteLine(report.createExport(""));

    Console.ReadLine();
}

static void Composite()
{   
    var localDate = DateTime.Now;
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, localDate, "Backlog");
    var birthday = new DateTime(2000, 1, 12);
    var notificationService = new EmailObserver();
    var user = new User("Tom", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER, notificationService);

    List<ForumComponent> reactionsUS1 = [new Reactions("Niemand gebruikt dit", localDate, user)];
    List<ForumComponent> reactionsUS2 = [new Reactions("Ik ga huilen hoor", localDate, user), new Reactions("...", localDate, user)];

    ForumComponent FirstUserStory = new Forum(backlogItem);
    FirstUserStory.Add(new Post("Waar is de rest van dit item?", "US is onduidelijk", localDate, user, reactionsUS1));

    FirstUserStory.Add(new Post("Help?", "US is onduidelijk", localDate, user, reactionsUS2));

    FirstUserStory.Print();
}

static void UserRoles()
{
    var birthday = new DateTime(2000, 1, 12);
    var notificationService = new EmailObserver();
    var user = new User("Tom", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER, notificationService);

    Console.WriteLine(user.toString());
    user.Name = "Test";
    Console.WriteLine(user.toString());
    user.Role = RoleType.SCRUM_MASTER;
    Console.WriteLine(user.toString());
}
