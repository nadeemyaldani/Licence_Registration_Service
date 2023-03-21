using APlus.Data.BLL;
using Blazorise;
using Microsoft.AspNetCore.Components;
using model = APlus.Data.Model;

namespace APlus.Pages
{
    public class AddSubscriptionBase : BaseComponent
    {
        [Inject]
        public SubscriptionBLL SubscriptionBLL { get; set; } = new(); 
        
        [Inject]
        public UserBLL UserBLL { get; set; } = new();

        [Inject]
        public PlanBLL PlanBLL { get; set; } = new();

        public model.Subscription Subscription { get; set; } = new();
        public List<model.Country> Countries { get; set; } = new();
        public List<model.Plan> Plans { get; set; } = new();


        [Parameter]
        public int Id { get; set; } = 0;

        protected override void OnInitialized()
        {
            Subscription.SubscriptionUser = new();
            Subscription = SubscriptionBLL.Get(Id).Result;
            Countries = new();
            Countries = UserBLL.GetCountries().Result;

            Plans = new List<model.Plan>();
            Plans = PlanBLL.GetAll().Result;
        }
    }
}
