using APlus.Data.Entity;
using APlus.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace APlus.Data.BLL
{
    public class UserBLL
    {
        #region Create
        public Task<SubscriptionUser> Create(SubscriptionUser user)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Add(user);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(user);
        }
        #endregion

        #region Read
        public Task<List<SubscriptionUser>> GetAll()
        {
            List<SubscriptionUser> users;
            using (EntityDBContext _dbContext = new())
            {
                users = _dbContext.Set<SubscriptionUser>().ToList();
            }
            return Task.FromResult(users);
        }
        public Task<SubscriptionUser> Get(int id)
        {
            SubscriptionUser user;
            using (EntityDBContext _dbContext = new())
            {
                user = _dbContext.Set<SubscriptionUser>().Where(w => w.Id == id).Include(a => a.Subscription).FirstOrDefault();
            }
            return Task.FromResult(user);
        }

        public Task<Country> GetCountry(int id)
        {
            Country country;
            using (EntityDBContext _dbContext = new())
            {
                country = _dbContext.Set<Country>().Where(w => w.Id == id).FirstOrDefault();
            }
            return Task.FromResult(country);
        }

        #endregion

        #region Update
        public Task<SubscriptionUser> Update(SubscriptionUser user)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Update(user);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(user);
        }
        #endregion

        #region Delete
        public Task<SubscriptionUser> Delete(SubscriptionUser user)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Remove(user);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(user);
        }
        #endregion
    }
}
