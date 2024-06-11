using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.CompositeForum;
using AvansDevOpsApplication.Domain.Factory;
using AvansDevOpsApplication.Domain.NotificationObserver;
using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain.StrategySprint;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

TestStrategySprint();
//TestBacklogIterface();
//ProjectBacklogExport();
//Composite();
//GenerateBurnDownChart();
//UserRoles();
//ExportPDF();

static void GenerateBurnDownChart()
{
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, DateTime.Now, "Backlog");
    var sprint = new ReviewSprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(4));
    sprint.AddItemToBacklog(backlogItem);
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

    List<ForumComponent> reactionsUS1 = [new Reaction("Niemand gebruikt dit", localDate, user)];
    List<ForumComponent> reactionsUS2 = [new Reaction("Ik ga huilen hoor", localDate, user), new Reaction("...", localDate, user)];

    ForumComponent FirstUserStory = new Forum(backlogItem);
    FirstUserStory.Add(new Post("Waar is de rest van dit item?", "US is onduidelijk", localDate, user));

    FirstUserStory.Add(new Post("Help?", "US is onduidelijk", localDate, user));
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

static void ProjectBacklogExport()
{
    Project project = new Project("Bende van ellende");
    var backlog = project.GetProjectBacklog();
    var item = new BacklogItem("Pray", "Praying for a good grade", null, DateTime.Now, "1");
    var item2 = new BacklogItem("Test", "Test", null, DateTime.Now, "1");
    backlog.AddItemToBacklog(item);
    backlog.AddItemToBacklog(item2);
    var reportTemplate = new YearReport(project.GetProjectBacklog());
    reportTemplate.GenerateReport();
}

static void TestBacklogIterface()
{
    var projectBacklog = new ProjectBacklog(Guid.NewGuid());
    var sprint = new ReviewSprint("", DateTime.Now, DateTime.Now);
    BacklogInterface projectBacklogInterface = projectBacklog;
    var item = new BacklogItem("Test", "Test", null, DateTime.Now, "1");
    var item2 = new BacklogItem("Test2", "Test", null, DateTime.Now, "1");
    projectBacklogInterface.AddItemToBacklog(item);
    projectBacklogInterface.AddItemToBacklog(item2);
    BacklogInterface sprintBacklog = sprint;
    BacklogProvider backlogProvider = projectBacklog;
    BacklogItemManager manager = new BacklogItemManager();
    manager.MoveBacklogItem(projectBacklog, sprintBacklog, item);


    Console.WriteLine(sprint.getBacklogItems().First().Name);
    Console.WriteLine(sprint.getBacklogItems().Count());
    manager.MoveBacklogItem(projectBacklog, sprintBacklog, item2);
    Console.WriteLine(sprint.getBacklogItems().Count());
}

static void TestStrategySprint()
{
    var releaseSprint = new ReleaseSprint("Test", DateTime.Now, DateTime.Now);
    releaseSprint.SetState(releaseSprint.GetActiveState());
    releaseSprint.AddItemToBacklog(new BacklogItem("Test", "Test", null, DateTime.Now, "1"));
    Console.WriteLine(releaseSprint.getBacklogItems().First().Name);
    releaseSprint.SetState(releaseSprint.GetFinishedState());
    releaseSprint.AddItemToBacklog(new BacklogItem("Test", "Test", null, DateTime.Now, "1"));
}
