using DesafioDev.Application.DTOs;
using DesafioDev.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace DesafioDev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] int skip = 0, int take = 2)
        {
            return Ok(this.applicationServiceProduto.GetAll(skip, take));
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(this.applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                {
                    return NotFound();
                }
                this.applicationServiceProduto.Delete(produtoDto);
                return Ok("Produto deletado com sucesso.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
