using System;

namespace MVC_Entity_App.Controllers
{
    internal class ApplicationDbContext
    {
        public object Insurees { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}