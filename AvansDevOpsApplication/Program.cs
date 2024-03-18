// See https://aka.ms/new-console-template for more information
using AvansDevOpsApplication.Domain;

var localDate = DateTime.Now;
var birthday = new DateOnly(2000, 1, 12);
var user = new User("Tom", "t@mail.com", 24, birthday, RoleType.LEAD_DEVELOPER);
Console.WriteLine(user.toString());
user.Name = "Test";
Console.WriteLine(user.toString());
user.Role = RoleType.SCRUM_MASTER;

Console.WriteLine(user.toString());

var activity = new Activity("help", "done", "not done", localDate);
Console.WriteLine(activity.toString());

var backlogItem = new BacklogItem("Name", "Nice description", null, localDate, "Backlog");
Console.WriteLine(backlogItem.toString());
backlogItem.AddActivityToList(activity);
Console.WriteLine(backlogItem.toString());