using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp.Data.Repository
{
    public class SqlBugRepo : IBugRepo
    {
        private readonly TrackerDbContext context;

        public SqlBugRepo(TrackerDbContext context)
        {
            this.context = context;
        }
        public Bug Add(Bug bug)
        {
            context.Bugs.Add(bug);
            context.SaveChanges();
            return bug;
        }

        public Bug Delete(int Id)
        {
           Bug bug =  context.Bugs.Find(Id);
            if(bug != null)
            {
                context.Bugs.Remove(bug);
                context.SaveChanges();
            }
            return bug;

        }

        public IEnumerable<Bug> GetAllBugs()
        {
            return context.Bugs;
        }

        public Bug GetBug(int Id)
        {
            return context.Bugs.Find(Id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public Bug Update(Bug update)
        {
            var bug = context.Bugs.Attach(update);
            bug.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return update;
        }
    }
}
