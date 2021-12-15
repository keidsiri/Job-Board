using System.Collections.Generic;

namespace JobBoard.Models
{
    public class Job
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Item> _jobList = new List<Item> { };

        public Job(string title, string description, string contact)
        {
            Title = title;
            Description = description;
            contact = contact;

            _jobList.Add(this);
            Id = _instances.Count;
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