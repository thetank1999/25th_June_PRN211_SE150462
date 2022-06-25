using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.IRepository
{
    public interface IJobTitleRepository
    {
        public IEnumerable<JobTitle> GetJobTitleList();
        public JobTitle GetJobTitleById(string id);
        public void AddJobTitle(JobTitle _JobTitle);
        public void UpdateJobTitle(JobTitle _JobTitle);
        public void RemoveJobTitle(JobTitle _JobTitle);

    }
}
