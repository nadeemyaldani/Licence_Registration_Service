using APlus.Data.Entity;
using APlus.Data.Model;

namespace APlus.Data.BLL
{
    public class SubscriptionBLL
    {
        #region Create
        public Task<Subscription> Create(Subscription subscription)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Add(subscription);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(subscription);
        }
        #endregion

        #region Read
        public Task<List<Subscription>> GetAll()
        {
            List<Subscription> subscriptions;
            using (EntityDBContext _dbContext = new())
            {
                subscriptions = _dbContext.Set<Subscription>().ToList();
            }
            return Task.FromResult(subscriptions);
        }
        public Task<Subscription> Get(int id)
        {
            Subscription subscription;
            using (EntityDBContext _dbContext = new())
            {
                subscription = _dbContext.Set<Subscription>().Where(w => w.Id == id)/*.Include(a => a.User)*/.FirstOrDefault();
            }
            return Task.FromResult(subscription);
        }
        #endregion

        #region Update
        public Task<Subscription> Update(Subscription subscription)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Update(subscription);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(subscription);
        }
        #endregion

        #region Delete
        public Task<Subscription> Delete(Subscription subscription)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Remove(subscription);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(subscription);
        }
        #endregion
    }
}
