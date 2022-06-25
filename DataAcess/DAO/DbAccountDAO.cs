using BusinessObject.Context;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DAO
{
    public class DbAccountDAO
    {
        #region [ Using Singleton ]
        private static DbAccountDAO instance = null;
        public static readonly object instanceLock = new object();
        public static DbAccountDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new DbAccountDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ public methods - CRUD ]
        public IEnumerable<Dbaccount> GetDbaccountList() {
            var DbaccountList = new List<Dbaccount>();
            try {
                using var context = new EmployeeJobTitleContext();
                DbaccountList = context.Dbaccounts.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return DbaccountList;
        }

        public Dbaccount GetDbaccountById(string id) {
            Dbaccount _tempDbaccount = null;
            try {
                using var context = new EmployeeJobTitleContext();
                _tempDbaccount = context.Dbaccounts.FirstOrDefault(x => x.AccountId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempDbaccount;
        }

        public void AddDbaccount(Dbaccount _Dbaccount) {
            try {
                var _tempDbaccount = this.GetDbaccountById(_Dbaccount.AccountId);
                if (_tempDbaccount == null) {
                    using var context = new EmployeeJobTitleContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Dbaccounts.Add(_Dbaccount);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Dbaccount Id is already existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateDbaccount(Dbaccount _Dbaccount) {
            try {
                Dbaccount tempDbaccount = this.GetDbaccountById(_Dbaccount.AccountId);
                if (tempDbaccount != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.Dbaccounts.Update(_Dbaccount);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Dbaccount Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveDbaccount(Dbaccount _Dbaccount) {
            try {
                Dbaccount _tempDbaccount = this.GetDbaccountById(_Dbaccount.AccountId);
                if (_tempDbaccount != null) {
                    using var context = new EmployeeJobTitleContext();
                    context.Dbaccounts.Remove(_tempDbaccount);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Dbaccount Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
        #region [ Login ]
        public Dbaccount Login(string IdEmail, string password) {
            try {
                var _tempDbaccount = this.GetDbaccountById(IdEmail);
                if (_tempDbaccount == null) {
                    return null;
                }
                else if (password.Equals(_tempDbaccount.AccountPassword)) {
                    return _tempDbaccount;
                } else {
                    return null;
                }
            } catch (Exception ex) { 
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
