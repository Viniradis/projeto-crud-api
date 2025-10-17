using Crud_Api.Models;
using Crud_Api.Service.ProdutoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoInterface _produtoInterface;
        public ProdutoController(IProdutoInterface produtoInterface)
        {
            _produtoInterface = produtoInterface;

        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> GetProdutos()
        {
            return Ok(await _produtoInterface.GetProdutos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ProdutoModel>>> GetProdutoById(int id)
        {
            ServiceResponse<ProdutoModel> serviceResponse = await _produtoInterface.GetProdutoById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> CreateProduto(ProdutoModel novoProduto)
        {
            return Ok(await _produtoInterface.CreateProduto(novoProduto));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> UpdateProduto(ProdutoModel editadoProduto)
        {
            ServiceResponse<List<ProdutoModel>> serviceResponse = await _produtoInterface.UpdateProduto(editadoProduto);
            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> DeleteProduto(int id)
        {
            ServiceResponse<List<ProdutoModel>> serviceResponse = await _produtoInterface.DeleteProduto(id);

            return Ok(serviceResponse);
        }
    }
}
