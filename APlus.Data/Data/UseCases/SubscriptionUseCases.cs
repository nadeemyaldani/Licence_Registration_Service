//using APlus.Data.BLL;
//using APlus.Data.Entity;
//using APlus.Data.Model;

//namespace APlus.Data.UseCases
//{
//    public class SubscriptionUseCases
//    {
//        UserBLL UserBLL;
//        SubscriptionBLL SubscriptionBLL;
//        public SubscriptionUseCases()
//        {
//            UserBLL = new();
//            SubscriptionBLL = new();
//        }
//        #region Create
//        public void Create(Subscription subscription)
//        {
//            User user = subscription.User;
//            Country country = UserBLL.GetCountry(user.CountryId).Result;
//            user = UserBLL.Create(user).Result;
//            subscription = SubscriptionBLL.Create(subscription).Result;

//            string AccountNo = $"{user.Id}-{subscription.Id}-{country.Code}";
//            user.AccountNo = AccountNo;
//            UserBLL.Update(user);
//        }
//        #endregion

//        //#region Read
//        //public Task<List<Subscription>> GetAll()
//        //{

//        //}
//        //public Task<Subscription> Get(int id)
//        //{

//        //}
//        //#endregion

//        //#region Update
//        //public Task<Subscription> Update(Subscription subscription)
//        //{

//        //}
//        //#endregion

//        //#region Delete
//        //public Task<Subscription> Delete(Subscription subscription)
//        //{
//        //}
//        //#endregion
//    }
//}
