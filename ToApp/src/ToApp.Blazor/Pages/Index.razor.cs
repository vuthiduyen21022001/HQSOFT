using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToApp.Blazor.Pages
{
    public partial class Index
    {
        [Inject]
        private IToAppService ToAppService { get; set; }
        private List<ToItemDto> ToItems { get; set; } = new List<ToItemDto>();
        private string NewToText { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ToItems = await ToAppService.GetListAsync();
        }

        private async Task Create()
        {
            var result = await ToAppService.CreateAsync(NewToText);
            ToItems.Add(result);
            NewToText = null;
        }

        private async Task Delete(ToItemDto todoItem)
        {
            await ToAppService.DeleteAsync(todoItem.Id);
            await Notify.Info("Deleted the todo item.");
            ToItems.Remove(todoItem);
        }
    }
}
