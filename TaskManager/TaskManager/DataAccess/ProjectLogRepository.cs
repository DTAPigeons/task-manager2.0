﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataAccess {
    class ProjectLogRepository : BaseRepository {
        private DbSet<ProjectLog> entities;

        public ProjectLogRepository() {
            entities = Context.Set<ProjectLog>();
        }

        public List<ProjectLog> GetAll() {
            return entities.ToList();
        }

        public List<ProjectLog> GetAllWithFilterExpresion(Expression<Func<ProjectLog, bool>> filter) {
            return entities.Where(filter).ToList();
        }

        public ProjectLog GetById(int id) {
            return entities.Where(entity => entity.ProjectLogId == id).FirstOrDefault();
        }

        public void Save(ProjectLog projectLog) {
            if (projectLog.ProjectLogId <= 0) {
                Insert(projectLog);
            }
            else {
                Update(projectLog);
            }

            Context.SaveChanges();
        }

        public void Insert(ProjectLog projectLog) {
            entities.Add(projectLog);
        }

        public void Update(ProjectLog projectLog) {
            Context.Entry(projectLog).State = EntityState.Modified;
        }

        public void Delete(ProjectLog projectLog) {
            entities.Remove(projectLog);
            Context.SaveChanges();
        }
    }
}
