using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.IRepository
{
    public interface IDbAccountRepository
    {
        public IEnumerable<Dbaccount> GetDbaccountList();
        public Dbaccount GetDbaccountById(string id);
        public void AddDbaccount(Dbaccount _Dbaccount);
        public void UpdateDbaccount(Dbaccount _Dbaccount);
        public void RemoveDbaccount(Dbaccount _Dbaccount);
        public Dbaccount Login(string IdEmail, string password);
    }
}
