using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace schedule.api.core.Base.Interfaces
{
    public interface IBaseController<T, TDto> where T : class, IBaseEntity where TDto : class, IBaseDto
    {
        Task<IActionResult> Get();
        Task<IActionResult> GetById(long id);
        Task<IActionResult> Post(TDto entityDto);
        Task<IActionResult> Put(long id, TDto entityDto);
        Task<IActionResult> Patch(long id, JsonPatchDocument<TDto> patchDto);
        Task<IActionResult> Delete(long id);
    }
}
