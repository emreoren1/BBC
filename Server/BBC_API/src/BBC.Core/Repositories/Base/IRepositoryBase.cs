﻿using BBC.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BBC.Core.Repositories.Base
{
    public interface IRepositoryBase<TDbContext, TEntity, TKey> : IRepository
    {
        #region Context
        //TDbContext GetDbContext();
        #endregion

        #region Insert
        void InsertGraph(TEntity entity, bool autoSave = true);
        TEntity Insert(TEntity entity, bool autoSave = true);
        Task<TEntity> InsertAsync(TEntity entity, bool autoSave = true);
        #endregion

        #region Update
        TEntity Update(TEntity entity, bool autoSave = true);
        Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = true);
        #endregion

        #region Delete
        void Delete(TEntity entity, bool autoSave = true);
        Task DeleteAsync(TEntity entity, bool autoSave = true);
        void Delete(Expression<Func<TEntity, bool>> predicate, bool autoSave = true);
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate, bool autoSave = true);
        void Delete(TKey id, bool autoSave = true);
        Task DeleteAsync(TKey id, bool autoSave = true);
        #endregion

        #region GetList with includeDetails
        List<TEntity> GetList(bool includeDetails = false);
        Task<List<TEntity>> GetListAsync(bool includeDetails = false);
        #endregion

        #region Count
        long GetCount();
        Task<long> GetCountAsync();
        #endregion

        #region GetQueryable
        IQueryable<TEntity> GetQueryable();
        IQueryable<TEntity> GetQueryableWithInclude(params Expression<Func<TEntity, object>>[] propertySelectors);
        #endregion

        #region Find
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(TKey id, bool includeDetails = true);
        Task<TEntity> FindAsync(TKey id, bool includeDetails = true);
        #endregion

        #region Get
        TEntity Get(TKey id, bool includeDetails = true);
        Task<TEntity> GetAsync(TKey id, bool includeDetails = true);
        #endregion

        #region GetSingle
        TEntity GetSingle(int id);
        TEntity GetSingleIncluding(int id, params Expression<Func<TEntity, object>>[] includeProperties);
        #endregion

        #region SaveChanges
        Task SaveChangesAsync();
        void SaveChanges();
        #endregion
    }
}
