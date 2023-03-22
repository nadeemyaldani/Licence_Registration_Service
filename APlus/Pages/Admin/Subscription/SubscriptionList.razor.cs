using APlus.Data.BLL;
using Blazorise;
using Microsoft.AspNetCore.Components;
using model = APlus.Data.Model;

namespace APlus.Pages
{
    public class SubscriptionListBase : BaseComponent
    {
        [Inject]
        public SubscriptionBLL SubscriptionBLL { get; set; } = new();

        [Inject]
        public UserBLL UserBLL { get; set; } = new();
        public List<model.Subscription> Subscriptions { get; set; } = new();

        protected override void OnInitialized()
        {
            Subscriptions = new();
            Subscriptions = SubscriptionBLL.GetAll().Result;
        }
    }
}
