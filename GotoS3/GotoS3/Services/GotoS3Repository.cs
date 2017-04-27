using GotoS3.API.Entities;
using GotoS3.API.Helpers;
using GotoS3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.API.Services
{
    public class GotoS3Repository : IGotoS3Repository
    {
        
        private GotoS3Context _context;

        public GotoS3Repository(GotoS3Context context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
        public Account GetAccount(int accountId)
        {
            return _context.Accounts.FirstOrDefault(a => a.Id == accountId);
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
        }

        public void DeleteAccount(Account account)
        {
            _context.Accounts.Remove(account);
        }

        public IEnumerable<Encryptor> GetEncryptors()
        {
            return _context.Encryptors;
        }

        public Encryptor GetEncryptor(int encryptorId)
        {
            return _context.Encryptors.FirstOrDefault(e => e.Id == encryptorId);
        }

        public void AddEncryptor(Encryptor encryptor)
        {
            _context.Encryptors.Add(encryptor);
        }

        public void DeleteEncryptor(Encryptor encryptor)
        {
            _context.Encryptors.Remove(encryptor);
        }

        public IEnumerable<string> GetRegions()
        {
            return new awsData().GetRegions();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
