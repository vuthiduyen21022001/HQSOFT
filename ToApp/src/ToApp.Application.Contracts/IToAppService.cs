using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ToApp
{
    public interface IToAppService : IApplicationService
    {
        Task<List<ToItemDto>> GetListAsync();
        Task<ToItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
