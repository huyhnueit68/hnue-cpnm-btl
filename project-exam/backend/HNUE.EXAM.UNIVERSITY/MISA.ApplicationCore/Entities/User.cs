using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.ApplicationCore.Entities
{   
    /// <summary>
    /// Class người dùng
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Khóa chính nhân viên
        /// </summary>
        [PrimaryKey]
        [DisplayName("Khóa chính người dùng")]
        public int EntityId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        [CheckDuplicate]
        [Required]
        [DisplayName("Tên đăng nhập")]
        public string UserName { get; set; }

        /// <summary>
        /// Mật khẩu
        /// </summary>
        [Required]
        public string Passwork { get; set; }

        /// <summary>
        /// Họ và tên người dùng
        /// </summary>
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        [DisplayName("Giới tính")]
        public int? Gender { get; set; }

        /// <summary>
        /// Ngày sinh người dùng
        /// </summary>
        [DisplayName("Ngày sinh")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        ///Số điện thoại
        /// </summary>
        [DisplayName("Số điện thoại di động")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        /// <summary>
        /// Tổng điểm
        /// </summary>
        [DisplayName("Tổng điểm")]
        public float TotalPoint { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        /// <summary>
        /// Phân quyền
        /// </summary>
        [DisplayName("Quyền")]
        public int Role { get; set; }

        /// <summary>
        /// Địa chỉ email
        /// </summary>
        [DisplayName("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Ngày tạo nhân viên
        /// </summary>
        [DisplayName("Ngày tạo")]
        public new DateTime? CreatedAt { get; set; }
    }
}
