using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace MikeBike.Client.Pages
{
    public partial class Index
    {
        [Inject]
        private IJSRuntime? JSRuntime { get; set; }
        private bool IsSmall { get; set; }
        private bool IsMedium { get; set; }
        private bool IsLarge { get; set; }


        private void LinktoJCA()
        {
            JSRuntime?.InvokeVoidAsync("open", "https://secure.everyaction.com/slwvQqNf3ES-Zo1eo14P5Q2", "_blank");
        }

        private void LinktoPillars()
        {
            JSRuntime?.InvokeVoidAsync("open", "https://crm.bloomerang.co/HostedDonation?ApiKey=pub_ea99c055-55c9-11eb-ba71-0686663776c3&WidgetId=4880384", "_blank");
        }
    }
}
