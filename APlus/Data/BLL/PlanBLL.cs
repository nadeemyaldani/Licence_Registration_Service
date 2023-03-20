using APlus.Data.Entity;
using APlus.Data.Model;

namespace APlus.Data.BLL
{
    public class PlanBLL
    {

        #region Create
        public Task<Plan> Create(Plan plan)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Add(plan);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(plan);
        }
        #endregion

        #region Read
        public Task<List<Plan>> GetAll()
        {
            List<Plan> plans;
            using (EntityDBContext _dbContext = new())
            {
                plans = _dbContext.Set<Plan>().ToList();
            }
            return Task.FromResult(plans);
        }
        public Task<Plan> Get(int id)
        {
            Plan plan;
            using (EntityDBContext _dbContext = new())
            {
                plan = _dbContext.Set<Plan>().Where(w => w.Id == id).FirstOrDefault();
            }
            return Task.FromResult(plan);
        }
        #endregion

        #region Update
        public Task<Plan> Update(Plan plan)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Update(plan);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(plan);
        }
        #endregion

        #region Delete
        public Task<Plan> Delete(Plan plan)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Remove(plan);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(plan);
        }
        #endregion

    }
}
