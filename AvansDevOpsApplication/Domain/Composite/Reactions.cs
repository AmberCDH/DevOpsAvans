﻿namespace AvansDevOpsApplication.Domain.Composite
{
    public class Reactions : ForumComponent
    {
        private string answer;
        private DateTime timestamp;
        private User user;

        public Reactions(string answer, DateTime timestamp, User user)
        {
            this.answer = answer;
            this.timestamp = timestamp;
            this.user = user;
        }

        public override void Print()
        {
            Console.WriteLine($" Reaction; {user.Name} {user.Email} ~ {answer} - {timestamp}");
        }


    }
}
