﻿using AvansDevOpsApplication.Domain.NotificationObserver;

namespace AvansDevOpsApplication.Domain
{
    public class User
    {
        private INotificationObserver notificationService;
        private Guid id;
        private string name;
        private string email;
        private DateTime birthday;
        private RoleType role;

        public User(string name, string email, DateTime birthday, RoleType role, INotificationObserver notificationService)
        {
            this.name = name;
            this.email = email;
            this.birthday = birthday;
            this.role = role;
            id = Guid.NewGuid();
            this.notificationService = notificationService;
        }
        public RoleType Role { 
            get { return role; }  
            set { role = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
        }

        public Guid Id { get => id; set => id = value; }

        public string toString()
        {
            return "User ~ Name; " + name + " ~ Birthday; " + birthday + " ~ Role; " + role;
        }
        public INotificationObserver GetNotificationService()
        {
            return notificationService;
        }
    }
}
