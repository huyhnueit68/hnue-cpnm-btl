using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces.Repository;
using MISA.ApplicationCore.Interfaces.Service;

namespace MISA.ApplicationCore.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        #region DECLARE
        IUserRepository _departmentRepository;
        #endregion

        #region Construct
        /// <summary>
        /// hàm khởi tạo cho department service
        /// </summary>
        /// <param name="departmentRepository"></param>
        /// CreatedBy: PQ Huy (06.07.2021)
        public UserService(IUserRepository departmentRepository) : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        #endregion 

        #region Method

        #endregion
    }
}
