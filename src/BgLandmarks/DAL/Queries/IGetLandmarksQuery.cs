using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Queries
{
    public interface IGetLandmarksQuery
    {
        List<Landmark> Execute();
    }
}
