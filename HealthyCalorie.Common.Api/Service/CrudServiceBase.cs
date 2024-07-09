using HealthyCalorie.Common.CrossCutting.Dtos;
using HealthyCalorie.Common.Storage;
using HealthyCalorie.Common.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.Common.Api.Service
{
    public class CrudServiceBase<TDbContext, TEntity, TDto>
            where TDbContext : TechnicalTrainingContext
            where TEntity : BaseEntity
            where TDto : class
    {
        public readonly TDbContext _dbContext;
        protected virtual Task OnBeforeRecordCreatedAsync(TDbContext dbContext, TEntity entity) => Task.CompletedTask;
        protected virtual Task ONAfterRecordCreatedAsync(TDbContext dbContext, TEntity entity) => Task.CompletedTask;

        public CrudServiceBase(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CrudOperationResult<TDto>> Delete(int id)
        {
            var entity = await _dbContext
                .Set<TEntity>()
                .SingleOrDefaultAsync(e => e.Id!.Equals(id));

            if (entity == null)
            {
                return new CrudOperationResult<TDto>
                {
                    Status = CrudOperationResultStatus.RecordNotFound,
                };
            }

            _dbContext.Set<TEntity>().Remove(entity);

            await _dbContext.SaveChangesAsync();
            return new CrudOperationResult<TDto>
            {
                Status = CrudOperationResultStatus.Success,
            };
        }

        public async Task<int> Create(TEntity entity)
        {
            await OnBeforeRecordCreatedAsync(_dbContext, entity);

            _dbContext
                .Set<TEntity>()
                .Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<CrudOperationResult<TDto>> Update(TEntity newEntity)
        {
            var entityBeforeUpdate = await GetById(newEntity.Id);

            if (entityBeforeUpdate == null)
            {
                return new CrudOperationResult<TDto>
                {
                    Status = CrudOperationResultStatus.RecordNotFound,
                };
            }

            _dbContext.Entry(newEntity).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return new CrudOperationResult<TDto>
            {
                Status = CrudOperationResultStatus.Success,
            };
        }

        protected async Task<TEntity?> GetById(int id)
        {
            var entity = await _dbContext
                .Set<TEntity>()
                .AsNoTracking()
                .Where(e => e.Id!.Equals(id))
                .SingleOrDefaultAsync();

            return entity;
        }

        public async Task<IEnumerable<TEntity>> Get()
        {
            var entities = await _dbContext
                .Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();

            return entities;
        }
    }
}
