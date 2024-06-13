﻿using AvansDevOpsApplication.Domain.SprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public class ReviewSprint : Sprint
    {
        private readonly ISprintState createdState;
        private readonly ISprintState activeState;
        private readonly ISprintState finishedState;
        public ReviewSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
            activeState = new ActiveReviewState(this);
            createdState = new CreatedReviewState(this);
            finishedState = new FinishedReviewState(this);
            base.SetState(createdState);
        }

        public ISprintState GetActiveState()
        {
            return activeState;
        }

        public ISprintState GetCreatedState()
        {
            return createdState;
        }

        public ISprintState GetFinishedState()
        {
            return finishedState;
        }
    }
}
