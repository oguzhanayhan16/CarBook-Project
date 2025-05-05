using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
   public class GetAboutQueryHandler
    {
        private readonly IRepository<About> repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            this.repository = repository;
        }
        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
