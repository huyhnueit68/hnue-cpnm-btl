using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces.Repository;
using MISA.Infrastructure;

namespace MISA.Infastructure
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region DECLARE

        #endregion

        #region Contructor
        public UserRepository(IConfiguration configuration) : base(configuration)
        {

        }
        #endregion

        #region Method


        #endregion
    }
}
