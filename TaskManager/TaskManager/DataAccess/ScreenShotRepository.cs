using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataAccess {
    class ScreenShotRepository: BaseRepository{
        private DbSet<Screenshots> entities;

        public ScreenShotRepository() {
            entities = Context.Set<Screenshots>();
        }

        public List<Screenshots> GetAll() {
            return entities.ToList();
        }

        public Screenshots GetById(int id) {
            return entities.Where(entity => entity.ScreenshotId == id).FirstOrDefault();
        }

        public void Save(Screenshots screenShot) {
            if (screenShot.ScreenshotId <= 0) {
                Insert(screenShot);
            }
            else {
                Update(screenShot);
            }

            Context.SaveChanges();
        }

        public void Insert(Screenshots screenShot) {
            entities.Add(screenShot);
        }

        public void Update(Screenshots screenShot) {
            Context.Entry(screenShot).State = EntityState.Modified;
        }

        public void Delete(Screenshots screenShot) {
            entities.Remove(screenShot);
            Context.SaveChanges();
        }
    }
}
