using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using schedule.api.core.Base.Interfaces;

namespace schedule.api.core.Base
{
    public abstract class BaseService<T, TDto> : IBaseService<T, TDto> where T : IBaseEntity where TDto : class, IBaseDto
    {
        protected readonly IBaseRepository<T> Repository;
        protected readonly IMapper Mapper;

        protected BaseService(
            IBaseRepository<T> repository,
            IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }
        public virtual async Task<ICollection<TDto>> GetAll()
        {
            var entities = await Repository.GetAll();
            var mappedDtoList = Mapper.Map<ICollection<TDto>>(entities);
            return mappedDtoList;
        }

        public virtual async Task<TDto> GetById(long id)
        {
            var entity = await Repository.GetById(id);
            if (entity == null)
                throw new InvalidOperationException($"Entity {id} was not found");

            var mappedDto = Mapper.Map<TDto>(entity);
            return mappedDto;
        }

        public virtual async Task<TDto> Create(TDto entityDto)
        {
            if (entityDto == null)
                throw new ArgumentNullException(nameof(entityDto));

            var entity = CreatePoco(entityDto);
            var created = await Repository.Create(entity);
            var mappedDto = Mapper.Map<TDto>(created);
            return mappedDto;
        }
        
        public virtual async Task Update(long id, TDto entityDto)
        {
            if (entityDto == null)
                throw new ArgumentNullException(nameof(entityDto));

            var itemToUpdate = await Repository.GetById(id);
            if (itemToUpdate == null)
                throw new InvalidOperationException($"Entity {id} was not found");

            entityDto.Id = id;
            Mapper.Map(entityDto, itemToUpdate);
            await Repository.Update(itemToUpdate);
        }

        public virtual async Task Patch(long id, JsonPatchDocument<TDto> patchDto)
        {
            if (patchDto == null)
                throw new ArgumentNullException(nameof(patchDto));

            var itemToUpdate = await Repository.GetById(id);
            if (itemToUpdate == null)
                throw new InvalidOperationException($"Entity {id} was not found");

            // this is recommended way from microsoft if you don't have domain model
            //var modificationDate = _timeService.GetCurrentTime();
            var updateData = Mapper.Map<TDto>(itemToUpdate);
            patchDto.ApplyTo(updateData);
            updateData.Id = id;
            Mapper.Map(updateData, itemToUpdate);
            // itemToUpdate.LastModified = modificationDate;
            await Repository.Update(itemToUpdate);
        }

        public virtual async Task Delete(long id)
        {
            var entity = await Repository.GetById(id);
            if (entity == null)
                throw new InvalidOperationException($"Entity {id} was not found");

            await Repository.Delete(entity);
        }

        public virtual T CreatePoco(TDto entityDto)
        {
            var entity = Mapper.Map<T>(entityDto);
            return entity;
        }

        public virtual TDto CreateDto(T entity)
        {
            var entityDto = Mapper.Map<TDto>(entity);
            return entityDto;
        }
        
        public Uri CreateResourceUri(long id)
        {
            return new Uri($"{id}", UriKind.Relative);
        }

        public virtual bool ValidateDto(TDto entityDto)
        {
            return entityDto != null;
        }

        public virtual bool ValidateUser(ClaimsPrincipal user, long id)
        {
            return user.Identity.IsAuthenticated
                   && user.Identity.Name == id.ToString();
        }
    }
}
