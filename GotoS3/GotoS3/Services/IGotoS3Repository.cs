using GotoS3.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.Services
{
    public interface IGotoS3Repository
    {
        IEnumerable<string> GetRegions();
        IEnumerable<Account> GetAccounts();
        Account GetAccount(int accountId);
        void AddAccount(Account account);
        void DeleteAccount(Account account);
        IEnumerable<Encryptor> GetEncryptors();
        Encryptor GetEncryptor(int encryptorId);
        void AddEncryptor(Encryptor encryptor);
        void DeleteEncryptor(Encryptor encryptor);
        //void UpdateAccount(Account account);
        //bool AccountExists(int accountId);
        //void DeleteAccount(Account account);
        //IEnumerable<Bucket> GetBuckets();
        //IEnumerable<Bucket> GetBucketForAccount(int accountId);
        //Bucket GetBucket(int bucketId);
        //IEnumerable<Encrypt> GetEncrypts();
        //Encrypt GetEncrypt(int encryptId);
        bool Save();


    }
}
