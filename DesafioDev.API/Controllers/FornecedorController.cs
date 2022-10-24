using DesafioDev.Application.DTOs;
using DesafioDev.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : Controller
    {
        private readonly IApplicationServiceFornecedor applicationServiceFornecedor;

        public FornecedorController(IApplicationServiceFornecedor applicationServiceFornecedor)
        {
            this.applicationServiceFornecedor = applicationServiceFornecedor;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] int skip = 0, int take = 2)
        {
            return Ok(this.applicationServiceFornecedor.GetAll(skip, take));
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(this.applicationServiceFornecedor.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] FornecedorDto fornecedorDto)
        {
            try
            {
                if (fornecedorDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceFornecedor.Add(fornecedorDto);
                return Ok("Fornecedor cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] FornecedorDto fornecedorDto)
        {
            try
            {
                if (fornecedorDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceFornecedor.Update(fornecedorDto);
                return Ok("Fornecedor atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] FornecedorDto fornecedorDto)
        {
            try
            {
                if (fornecedorDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceFornecedor.Delete(fornecedorDto);
                return Ok("Fornecedor deletado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
