﻿using System.Collections.Generic;

namespace PGM.Model
{
    public class GitlabIssue
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public GitlabMilestone Milestone { get; set; }
        
        public List<string> Labels { get; set; }

        public List<GitlabAssignee> Assignees { get; set; }

        public StepType StepType { get; set; }

        public bool IsClosed { get; set; }

        public string WebUrl { get; set; }

        public GitlabProject CurrentProject { get; set; }
    }
}