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

        public model.Subscription Subscription { get; set; } = new();


        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            Subscription = SubscriptionBLL.Get(Id).Result;
        }
    }
}
