using DAL.Entities;
using System.Collections.Generic;
using System.Text.Json;

namespace DAL.Seeder
{
    public class LandmarkSeeder
    {
        public LandmarkSeeder()
        {
            var historyAndCulture = JsonSerializer.Deserialize<List<Landmark>>(SeedData.HistoryAndCulture);
            var monasteryAndTemples = JsonSerializer.Deserialize<List<Landmark>>(SeedData.МonasteriesАndТemples);
            var landmarks = JsonSerializer.Deserialize<List<Landmark>>(SeedData.Landmarks);

            Landmarks = new List<Landmark>();
            Landmarks.AddRange(historyAndCulture);
            Landmarks.AddRange(monasteryAndTemples);
            Landmarks.AddRange(landmarks);
        }

        public List<Landmark> Landmarks { get; }
    }
}
