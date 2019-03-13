using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataAccess {
    class UserRepository: BaseRepository {
        private DbSet<User> entities;

        public UserRepository() {
            entities = Context.Set<User>();
        }

        public List<User> GetAll() {
            return entities.ToList();
        }

        public User GetById(int id) {
            return entities.Where(entity => entity.UserId == id).FirstOrDefault();
        }

        public User GetByUsername(string userName) {
            return entities.Where(entity => entity.Username == userName).FirstOrDefault();
        }

        public void Save(User user) {
            if (user.UserId <= 0) {
                Insert(user);
            }
            else {
                Update(user);
            }

            Context.SaveChanges();
        }

        public void Insert(User user) {
            entities.Add(user);
        }

        public void Update(User user) {
            Context.Entry(user).State = EntityState.Modified;
        }

        public void Delete(User user) {
            entities.Remove(user);
            Context.SaveChanges();
        }

        public bool UserCanLogIn(string userName, string passWord) {
            User user = entities.Where(entitie => entitie.Username == userName && entitie.Password == passWord).FirstOrDefault();
            return (user != null && user.UserId > 0);
        }

        public bool UserNameIsTaken(string userName) {
            User user = entities.Where(entitie => entitie.Username == userName).FirstOrDefault();
            return (user != null && user.UserId > 0);
        }
    }
}
