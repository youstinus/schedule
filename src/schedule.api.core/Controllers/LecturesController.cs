using schedule.api.core.Base;
using schedule.api.core.Base.Interfaces;
using schedule.api.core.Controllers.Interfaces;
using schedule.api.core.Models;
using schedule.api.core.Models.Dto;

namespace schedule.api.core.Controllers
{
    public class LecturesController : BaseController<Lecture, LectureDto>, ILecturesController
    {
        public LecturesController(IBaseService<Lecture, LectureDto> service) : base(service)
        {
        }
    }
}
