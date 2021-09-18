using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces.Service;
using MISA.CukCuk.Web.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.AMIS.Web.Controllers
{
    /// <summary>
    /// Api Danh mục vị trí phòng ban
    /// CreatedBy: PQ Huy (05.07.2021)
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    public class UsersController : BaseEntityController<User>
    {
        #region DECLARE
        IUserService _departmentService;
        #endregion

        #region Contructor
        public UsersController(IUserService departmentService) : base(departmentService)
        {
            _departmentService = departmentService;
        }
        #endregion

        #region Method

        #endregion
    }
}
