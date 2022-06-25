using BusinessObject.Models;
using DataAcess.DAO;
using DataAcess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class DbAccountRepository : IDbAccountRepository
    {
        public void AddDbaccount(Dbaccount _Dbaccount) => DbAccountDAO.Instance.AddDbaccount(_Dbaccount);

        public Dbaccount GetDbaccountById(string id) => DbAccountDAO.Instance.GetDbaccountById(id);

        public IEnumerable<Dbaccount> GetDbaccountList() => DbAccountDAO.Instance.GetDbaccountList();

        public Dbaccount Login(string IdEmail, string password) => DbAccountDAO.Instance.Login(IdEmail, password);

        public void RemoveDbaccount(Dbaccount _Dbaccount) => DbAccountDAO.Instance.RemoveDbaccount(_Dbaccount);

        public void UpdateDbaccount(Dbaccount _Dbaccount) => DbAccountDAO.Instance.UpdateDbaccount(_Dbaccount);
    }
}
