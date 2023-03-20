using APlus.Data.Entity;
using APlus.Data.Model;

namespace APlus.Data.BLL
{
    public class PlanServiceBLL
    {
        #region Create
        public Task<PlanService> Create(PlanService planService)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Add(planService);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(planService);
        }
        #endregion

        #region Read
        public Task<List<PlanService>> GetAll()
        {
            List<PlanService> planServices;
            using (EntityDBContext _dbContext = new())
            {
                planServices = _dbContext.Set<PlanService>().ToList();
            }
            return Task.FromResult(planServices);
        }
        public Task<PlanService> Get(int id)
        {
            PlanService planService;
            using (EntityDBContext _dbContext = new())
            {
                planService = _dbContext.Set<PlanService>().Where(w => w.Id == id).FirstOrDefault();
            }
            return Task.FromResult(planService);
        }
        #endregion

        #region Update
        public Task<PlanService> Update(PlanService planService)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Update(planService);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(planService);
        }
        #endregion

        #region Delete
        public Task<PlanService> Delete(PlanService planService)
        {
            using (EntityDBContext _dbContext = new())
            {
                _dbContext.Remove(planService);
                _dbContext.SaveChanges();
            }
            return Task.FromResult(planService);
        }
        #endregion
    }
}
