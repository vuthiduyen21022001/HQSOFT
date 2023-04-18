using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToApp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ToApp
{
    public class ToAppService : ApplicationService, IToAppService
    {
        private readonly IRepository<ToItem, Guid> _toItemRepository;

        public ToAppService(IRepository<ToItem, Guid> toItemRepository)
        {
            _toItemRepository = toItemRepository;
        }

        public async Task<List<ToItemDto>> GetListAsync()
        {
            var items = await _toItemRepository.GetListAsync();
            return items
                .Select(item => new ToItemDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }

        public async Task<ToItemDto> CreateAsync(string text)
        {
            var toItem = await _toItemRepository.InsertAsync(
                new ToItem { Text = text }
            );

            return new ToItemDto
            {
                Id = toItem.Id,
                Text = toItem.Text
            };
        }
        public async Task DeleteAsync(Guid id)
        {
            await _toItemRepository.DeleteAsync(id);
        }



        // TODO: Implement the methods here...
    }
}
