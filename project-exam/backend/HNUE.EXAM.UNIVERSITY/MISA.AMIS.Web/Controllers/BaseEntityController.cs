﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Enums;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Web.Controllers
{
    /// <summary>
    /// Base controller
    /// </summary>
    /// <typeparam name="Generic">generic</typeparam>
    /// CreatedBy: PQ Huy (05.07.2021)
    [Route("v1/[controller]")]
    [ApiController]
    public class BaseEntityController<Generic> : ControllerBase
    {
        #region DECLARE
        IBaseService<Generic> _baseService;
        #endregion

        #region Contructor
        public BaseEntityController(IBaseService<Generic> baseService)
        {
            _baseService = baseService;
        }
        #endregion

        #region Method

        // GET: api/<BaseEntityController>/1
        /// <summary>
        /// Lấy ra tất cả các bản ghi
        /// </summary>
        /// <returns>Trả về tất cả các bản ghi</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // gọi function lấy dữ liệu
                var data = _baseService.Get();

                //trả về dữ liệu
                return Ok(data);
            } catch (Exception)
            {
                throw;
            }
            
        }

        // GET api/<BaseEntityController>/2
        /// <summary>
        /// Lấy dữ liệu bản ghi theo id
        /// </summary>
        /// <returns>Trả về bản ghi với id tương ứng</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                // gọi function lấy dữ liệu
                var data = _baseService.GetById(id);

                //trả về dữ liệu
                return Ok(data);
            }
            catch (Exception ce)
            {
                //trả về dữ liệu
                return BadRequest(ce);
            }
            
        }

        // POST api/<BaseEntityController>/3
        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <returns>Trả về kết quả trạng thái thêm mới bản ghi</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpPost]
        public IActionResult Post([FromBody] Generic data)
        {
            try
            {
                // gọi function lấy dữ liệu
                var serviceResult = _baseService.Insert(data);

                //trả về dữ liệu
                if (serviceResult.MISACode == MISAEnum.NotValid)
                {
                    return BadRequest(serviceResult);
                }

                // kiểm tra dữ liệu hợp lệ
                if (serviceResult.MISACode == MISAEnum.IsValid)
                {
                    return Created("EntityData", data);
                }
                else
                {
                    return BadRequest(serviceResult);
                }
            }
            catch (Exception ce)
            {
                //trả về dữ liệu
                return BadRequest(ce);
            }
            
        }

        // POST api/<BaseEntityController>/4
        /// <summary>
        /// Import dữ liệu với file excel
        /// </summary>
        /// <param name="formFile">form file</param>
        /// <param name="cancellationToken">cancel lation Token</param>
        /// <returns>Trả về tất cả các bản ghi</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpPost("import")]
        public string Import(IFormFile formFile, CancellationToken cancellationToken)
        {
            try
            {
                // get service
                var resultGeneric = _baseService.ProcessDataImport(formFile, cancellationToken);

                // xử lý trả về dữ liệu
                return resultGeneric;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        // PUT api/<BaseEntityController>/5
        /// <summary>
        /// Sửa dữ liệu bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <param name="data">dữ liệu sửa</param>
        /// <returns>Trả về bản ghi sau khi sửa</returns>
        /// CreatedBy: PQ Huy (05.07.2021)

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute]Guid id, [FromBody] Generic data)
        {
            try
            {
                // gọi function lấy dữ liệu
                var serviceResult = _baseService.Update(id, data);

                //trả về dữ liệu
                if (serviceResult.MISACode == MISAEnum.NotValid)
                {
                    return BadRequest(serviceResult);
                }
                if (serviceResult.MISACode == MISAEnum.IsValid || serviceResult.MISACode == MISAEnum.Success)
                {
                    return Created("EntityData", data);
                }
                else
                {
                    return Ok(serviceResult);
                }
            }
            catch (Exception ce)
            {
                //trả về dữ liệu
                return BadRequest(ce);
            }
            
        }

        // DELETE api/<BaseEntityController>/6
        /// <summary>
        /// Xóa bản ghi theo id
        /// </summary>
        /// <returns>Trả về trạng thái sau khi xóa</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                // gọi function lấy dữ liệu
                var serviceResult = _baseService.DeleteById(id);

                //trả về dữ liệu
                if (serviceResult.MISACode == MISAEnum.NotValid)
                {
                    return BadRequest(serviceResult);
                }

                // check is success
                if (serviceResult.MISACode == MISAEnum.IsValid || serviceResult.MISACode == MISAEnum.Success)
                {
                    return Ok(serviceResult);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ce)
            {
                //trả về dữ liệu
                return BadRequest(ce); ;
            }
            
        }

        // Mass Insert api/<BaseEntityController>/7
        /// <summary>
        /// Thêm nhiều bản ghi với key cache
        /// </summary>
        /// <returns>Trả về tổng số bản ghi sau khi thêm</returns>
        /// CreatedBy: PQ Huy (05.07.2021)
        [HttpPost("{keycache}")]
        public IActionResult MassInsert(string keycache)
        {
            try
            {
                // gọi function lấy dữ liệu
                var serviceResult = _baseService.MutilpleInsert(keycache);

                //trả về dữ liệu
                if (serviceResult.MISACode == MISAEnum.NotValid)
                {
                    return BadRequest(serviceResult);
                }

                // check is success
                if (serviceResult.MISACode == MISAEnum.IsValid || serviceResult.MISACode == MISAEnum.Success)
                {
                    return Ok(serviceResult);
                }
                else
                {
                    return BadRequest(serviceResult);
                }
            }
            catch (Exception ce)
            {
                //trả về dữ liệu
                return BadRequest(ce);
            }
            
        }

        #endregion
    }
}
