using DAL.Entities;
using System.Collections.Generic;
using System.Text.Json;

namespace DAL.Queries
{
    public class GetLandmarksQuery : IGetLandmarksQuery
    {
        public List<Landmark> Execute()
        {
            List<Landmark> landmarks = new List<Landmark>();

            var historyAndCulture = JsonSerializer.Deserialize<List<Landmark>>(SeedData.HistoryAndCulture);
            var monasteryAndTemples = JsonSerializer.Deserialize<List<Landmark>>(SeedData.МonasteriesАndТemples);
            var landmarksData = JsonSerializer.Deserialize<List<Landmark>>(SeedData.Landmarks);

            landmarks.AddRange(historyAndCulture);
            landmarks.AddRange(monasteryAndTemples);
            landmarks.AddRange(landmarks);

            return landmarks;
        }
    }
}
