﻿using AvansDevOpsApplication.Domain;
using AvansDevOpsApplication.Domain.ActivityState;
using AvansDevOpsApplication.Domain.CompositeForum;
using AvansDevOpsApplication.Domain.Factory;
using AvansDevOpsApplication.Domain.NotificationObserver;
using AvansDevOpsApplication.Domain.ReportTemplate;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;
using AvansDevOpsApplication.Domain.StrategySprint;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
//TestSprintSetNameWhenCreated();
//TestReviewSprint();
//TestActivityState();
//TestBacklogItemState();
//TestStrategySprint();
//TestBacklogIterface();
//ProjectBacklogExport();
//Composite();
//GenerateBurnDownChart();
//UserRoles();
//ExportPDF();

static void GenerateBurnDownChart()
{
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, DateTime.Now);
    var sprint = new ReviewSprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(4));
    sprint.AddItemToBacklog(backlogItem);
}

static void ExportPDF()
{
    var localDate = DateTime.Now;
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, localDate);
    var birthday = new DateTime(2000, 1, 12);
    var notificationService = new EmailObserver();
    var user = new User("Tom", "t@mail.com", birthday, RoleType.LEAD_DEVELOPER, notificationService);
    var user1 = new User("Tristan", "t@mail.com", birthday, RoleType.LEAD_DEVELOPER, notificationService);

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
    var backlogItem = new BacklogItem("Als gebruiker...", "Nice description", null, localDate);
    var birthday = new DateTime(2000, 1, 12);
    var notificationService = new EmailObserver();
    var user = new User("Tom", "t@mail.com", birthday, RoleType.LEAD_DEVELOPER, notificationService);

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
    var user = new User("Tom", "t@mail.com", birthday, RoleType.LEAD_DEVELOPER, notificationService);

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
    var item = new BacklogItem("Pray", "Praying for a good grade", null, DateTime.Now);
    var item2 = new BacklogItem("Test", "Test", null, DateTime.Now);
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
    var item = new BacklogItem("Test", "Test", null, DateTime.Now);
    var item2 = new BacklogItem("Test2", "Test", null, DateTime.Now);
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
    releaseSprint.AddItemToBacklog(new BacklogItem("Test", "Test", null, DateTime.Now));
    Console.WriteLine(releaseSprint.getBacklogItems().First().Name);
    releaseSprint.SetState(releaseSprint.GetFinishedState());
    releaseSprint.AddItemToBacklog(new BacklogItem("Test", "Test", null, DateTime.Now));
}

static void TestBacklogItemState()
{
    var activity = new Activity("Doe maar iets maken ofzo", "Mooie activity");
    var activity2 = new Activity("Maak iets vreemds in de code", "Nieuwe activity");
    var activitys = new List<Activity>();
    activitys.Add(activity);
    activitys.Add(activity2);
    var backlogItem = new BacklogItem("Test", "Test", activitys, DateTime.Now);
    var notificationService = new EmailObserver();
    var user = new User("Test", "test", DateTime.Now, RoleType.LEAD_DEVELOPER, notificationService);
    var testUser = new User("Test", "test", DateTime.Now, RoleType.TESTER, notificationService);
    backlogItem.AssignUser(user);
    backlogItem.ChangeState(backlogItem.GetDoingState());
    backlogItem.RemoveUser(user);
    backlogItem.ChangeState(backlogItem.GetReadyForTestingState());
    backlogItem.AssignUser(user);
    backlogItem.ChangeState(backlogItem.GetTestingState());
    backlogItem.AssignUser(testUser);
    backlogItem.ChangeState(backlogItem.GetTestingState());
    backlogItem.RemoveUser(testUser);
    //backlogItem.ChangeState(backlogItem.GetTodoState());
    //backlogItem.ChangeState(backlogItem.GetDoingState());
    backlogItem.ChangeState(backlogItem.GetDoneState());
    activity.SetState(new DoneActivityState());
    activity2.SetState(new DoneActivityState());
    backlogItem.ChangeState(backlogItem.GetDoneState());
    backlogItem.ChangeState(backlogItem.GetTodoState());
}

static void TestActivityState()
{
    var activity = new Activity("Doe maar iets maken ofzo", "Mooie activity");
    Console.WriteLine(activity.getState().ToString());
    activity.ChangeState(new ToDoActivityState(activity));
    Console.WriteLine(activity.getState().ToString());
    activity.ChangeState(new DoneActivityState());
    Console.WriteLine(activity.getState().ToString());
    activity.ChangeState(new DoneActivityState());
    Console.WriteLine(activity.getState().ToString());
}

static void TestReviewSprint(){
    var projectBacklog = new ProjectBacklog(Guid.NewGuid());
    var sprint = new ReviewSprint("", DateTime.Now, DateTime.Now);
    BacklogInterface projectBacklogInterface = projectBacklog;
    BacklogProvider projectBacklogProvider = projectBacklog;

    BacklogProvider biProvider = sprint;
    BacklogInterface biInterface = sprint;

    var item = new BacklogItem("Test", "Test", null, DateTime.Now);
    var item2 = new BacklogItem("Test2", "Test", null, DateTime.Now);
    projectBacklogInterface.AddItemToBacklog(item);
    projectBacklogInterface.AddItemToBacklog(item2);

    BacklogItemManager manager = new BacklogItemManager();


    manager.MoveBacklogItem(projectBacklog, sprint, item);
    
    Console.WriteLine(sprint.getBacklogItems().First().Name);
    Console.WriteLine(sprint.getBacklogItems().Count());
    manager.MoveBacklogItem(projectBacklog, sprint, item);
    Console.WriteLine(sprint.getBacklogItems().Count());
}

static void TestSprintSetNameWhenCreated()
{
    var sprint = new ReviewSprint("groen", DateTime.Now, DateTime.Now);
    Console.WriteLine(sprint.Name);
    Console.WriteLine(sprint.StartTime);
    Console.WriteLine(sprint.EndTime);
    sprint.SetName("Blauw");
    sprint.SetStartTime(new DateTime(1995, 1, 1));
    sprint.SetEndTime(new DateTime(1995, 1, 1));
    Console.WriteLine(sprint.Name);
    Console.WriteLine(sprint.StartTime);
    Console.WriteLine(sprint.EndTime);
    sprint.SetState(new CancelReviewState());
    sprint.SetName("Send help");
    sprint.SetStartTime(DateTime.Now);
    sprint.SetEndTime(DateTime.Now);
    Console.WriteLine(sprint.Name);
    Console.WriteLine(sprint.StartTime);
    Console.WriteLine(sprint.EndTime);
    var item = new BacklogItem("Test", "Test", null, DateTime.Now);
    sprint.AddItemToBacklog(item);
}