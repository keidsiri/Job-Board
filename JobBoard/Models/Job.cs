using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
    public class Job
    {
        public string Description { get; set; }
        public string Title {get; set; }
        public string Contact { get; set; } 
        public int Id { get; }
        private static List<Job> _jobList = new List<Job> { };

        public Job(string title, string description, string contact)
        {
            Title = title;
            Description = description;
            Contact = contact;

            _jobList.Add(this);
            Id = _jobList.Count;
        }

        public static List<Job> GetAll()
        {
            return _jobList;
        }

        public static void ClearAll()
        {
            _jobList.Clear();
        }

        public static Job Find(int searchId)
        {
            return _jobList[searchId - 1];
        }
    }
}