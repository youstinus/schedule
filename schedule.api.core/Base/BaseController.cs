using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using schedule.api.core.Base.Interfaces;

namespace schedule.api.core.Base
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<T, TDto> : ControllerBase, IBaseController<T, TDto> where T : class, IBaseEntity where TDto : class, IBaseDto
    {
        protected readonly IBaseService<T, TDto> Service;

        protected BaseController(IBaseService<T, TDto> service)
        {
            Service = service;
        }
        
        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var entities = await Service.GetAll();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById([FromRoute] long id)
        {
            try
            {
                var entity = await Service.GetById(id);
                return Ok(entity);
            }
            catch (InvalidOperationException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TDto entity)
        {
            if (!ModelState.IsValid && !Service.ValidateDto(entity))
                return BadRequest();

            try
            {
                var createdEntity = await Service.Create(entity);
                var entityUri = Service.CreateResourceUri(createdEntity.Id);
                return Created(entityUri, createdEntity);
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put([FromRoute] long id, [FromBody] TDto entity)
        {
            if (!ModelState.IsValid && !Service.ValidateDto(entity))
                return BadRequest();

            try
            {
                await Service.Update(id, entity);
                return NoContent();
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPatch("{id}")]
        public virtual async Task<IActionResult> Patch([FromRoute] long id, [FromBody] JsonPatchDocument<TDto> patchDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await Service.Patch(id, patchDto);
                return NoContent();
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete([FromRoute] long id)
        {
            try
            {
                await Service.Delete(id);
                return NoContent();
            }
            catch (InvalidOperationException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
