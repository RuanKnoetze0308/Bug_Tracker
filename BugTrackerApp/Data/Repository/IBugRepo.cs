using BugTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackerApp.Data.Repository
{
    public interface IBugRepo
    {
        void Save();

        Bug GetBug(int Id); //Read
        IEnumerable<Bug> GetAllBugs(); //Read
        Bug Add(Bug bug); //Create
        Bug Update(Bug update); //Update
        Bug Delete(int Id); //Delete

    }
}
