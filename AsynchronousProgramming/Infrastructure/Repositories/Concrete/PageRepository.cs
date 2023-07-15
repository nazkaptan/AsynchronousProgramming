﻿using AsynchronousProgramming.Infrastructure.Context;
using AsynchronousProgramming.Models.Entities.Concrete;

namespace AsynchronousProgramming.Infrastructure.Repositories.Concrete
{
    public class PageRepository : BaseRepository<Page>
    {
        public PageRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
