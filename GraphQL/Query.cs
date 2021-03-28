using System.Linq;
using Database;
using Models;

namespace GraphQL
{
    public class Query
    {
        private readonly TimeGraphContext dbContext;
        public Query(TimeGraphContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IQueryable<Project> Projects => dbContext.Projects;
        public IQueryable<TimeLog> TimeLogs => dbContext.TimeLogs;
    }
}