using BusinessObject.Context;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess.DAO
{
    public class JobTitleDAO
    {
        #region [ Using Singleton ]
        private static JobTitleDAO instance = null;
        public static readonly object instanceLock = new object();
        public static JobTitleDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new JobTitleDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ public methods - CRUD ]
        public IEnumerable<JobTitle> GetJobTitleList() {
            var JobTitleList = new List<JobTitle>();
            try {
                using var context = new EmployeeJobTitleContext();
                JobTitleList = context.JobTitles.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return JobTitleList;
        }

        public JobTitle GetJobTitleById(string id) {
            JobTitle _tempJobTitle = null;
            try {
                using var context = new EmployeeJobTitleContext();
                _tempJobTitle = context.JobTitles.FirstOrDefault(x => x.JobTitleId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempJobTitle;
        }

        public void AddJobTitle(JobTitle _JobTitle) {
            try {
                var _tempJobTitle = this.GetJobTitleById(_JobTitle.JobTitleId);
                if (_tempJobTitle == null) {
                    using var context = new EmployeeJobTitleContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.JobTitles.Add(_JobTitle);
                    context.SaveChanges();
                } else {
                    throw new Exception("The JobTitle Id is already existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateJobTitle(JobTitle _JobTitle) {
            try {
                JobTitle tempJobTitle = this.GetJobTitleById(_JobTitle.JobTitleId);
                if (tempJobTitle != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.JobTitles.Update(_JobTitle);
                    context.SaveChanges();

                } else {
                    throw new Exception("The JobTitle Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveJobTitle(JobTitle _JobTitle) {
            try {
                JobTitle _tempJobTitle = this.GetJobTitleById(_JobTitle.JobTitleId);
                if (_tempJobTitle != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.JobTitles.Remove(_tempJobTitle);
                    context.SaveChanges();
                } else {
                    throw new Exception("The JobTitle Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
