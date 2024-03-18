namespace AvansDevOpsApplication.Domain
{
    public class User
    {
        private Guid id;
        private string name;
        private string email;
        private int age;
        private DateOnly birthday;
        private RoleType role;

        public User(string name, string email, int age, DateOnly birthday, RoleType role)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.birthday = birthday;
            this.role = role;
            this.id = Guid.NewGuid();
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
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateOnly Birthday
        {
            get { return birthday; }
        }

        public string toString()
        {
            return "User ~ Name; " + name + " ~ Age; " + age + " ~ Birthday; " + birthday + " ~ Role; " + role;
        }
    }
}
