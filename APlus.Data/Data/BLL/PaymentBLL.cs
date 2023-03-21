using APlus.Data.Entity;
using APlus.Data.Model;

namespace APlus.Data.BLL
{
    public class PaymentBLL
    {
        #region Create
        public Task<Payment> Create(Payment payment)
        {
            using (EntityDBContext _dbContext = new())
            {

                _dbContext.Add(payment);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(payment);
        }
        #endregion

        #region Read
        public Task<List<Payment>> GetAll()
        {
            List<Payment> payments;
            using (EntityDBContext _dbContext = new())
            {
                payments = _dbContext.Set<Payment>().ToList();
            }
            return Task.FromResult(payments);
        }
        public Task<Payment> Get(int id)
        {
            Payment payment;
            using (EntityDBContext _dbContext = new())
            {
                payment = _dbContext.Set<Payment>().Where(w => w.Id == id).FirstOrDefault();
            }
            return Task.FromResult(payment);
        }
        #endregion

        #region Update
        public Task<Payment> Update(Payment payment)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Update(payment);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(payment);
        }
        #endregion

        #region Delete
        public Task<Payment> Delete(Payment payment)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Remove(payment);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(payment);
        }
        #endregion
    }
}
