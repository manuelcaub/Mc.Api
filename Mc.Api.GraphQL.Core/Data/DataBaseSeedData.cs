namespace Mc.Api.Core.Data
{
    using System.Linq;
    using Mc.Api.Core.Models;

    public static class DataBaseSeedData
    {
        public static void EnsureSeedData(this DataBaseContext db)
        {
            if (!db.Droids.Any())
            {
                var droid = new Droid
                {
                    Name = "R2-D2"
                };
                db.Droids.Add(droid);
                db.SaveChanges();
            }
        }
    }
}
