using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entities.Core;
using WebApp.Helpers;
using WebApp.Repositories;

namespace WebApp.Services
{
    public class GetDetailsService : IGetDetailsService
    {
        private DataContext _dataContext;

        public GetDetailsService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<IdentifiedObject> GetIdentifiedObjects()
        {
            return _dataContext.IdentifiedObjects
                .Select(io => new IdentifiedObject()
                {
                    AliasName = io.AliasName,
                    MRID = io.MRID,
                    Name = io.Name
                }).ToList();
        }
    }
}
