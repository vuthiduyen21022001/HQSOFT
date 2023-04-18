using System;
using Volo.Abp.Domain.Entities;

namespace ToApp
{
    public class ToItem : BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
