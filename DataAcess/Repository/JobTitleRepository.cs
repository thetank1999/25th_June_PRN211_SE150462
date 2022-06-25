using BusinessObject.Models;
using DataAcess.DAO;
using DataAcess.IRepository;
using System.Collections.Generic;

namespace DataAcess.Repository
{
    public class JobTitleRepository : IJobTitleRepository
    {
        public void AddJobTitle(JobTitle _JobTitle)  => JobTitleDAO.Instance.AddJobTitle(_JobTitle);

        public JobTitle GetJobTitleById(string id) => JobTitleDAO.Instance.GetJobTitleById(id);

        public IEnumerable<JobTitle> GetJobTitleList() => JobTitleDAO.Instance.GetJobTitleList();

        public void RemoveJobTitle(JobTitle _JobTitle) => JobTitleDAO.Instance.RemoveJobTitle(_JobTitle);

        public void UpdateJobTitle(JobTitle _JobTitle) => JobTitleDAO.Instance.UpdateJobTitle(_JobTitle);
    }
}
