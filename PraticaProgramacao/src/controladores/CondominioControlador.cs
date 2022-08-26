using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PraticaProgramacao.src.dtos;
using PraticaProgramacao.src.repositorios;
using System;
using System.Threading.Tasks;

namespace PraticaProgramacao.src.controladores
{
    [ApiController]
    [Route("api/Condominios")]
    [Produces("Application/json")]
    public class CondominioControlador : ControllerBase
    {
        #region Atributos

        private readonly ICondominio _repositorio;

        #endregion Atributos

        #region Contrutores

        public CondominioControlador(ICondominio repositorio)
        {
            _repositorio = repositorio;
        }

        #endregion Contrutores

        #region Métodos

        [HttpGet("id/{idCondominio}")]
        public async Task<ActionResult> PegarCondominioPeloIdAsync([FromRoute]int idCondominio)
        {
            var condominio = await _repositorio.PegarCondominioPeloIdAsync(idCondominio);

            if (condominio == null) return NotFound();

            return Ok(condominio);
        }

        [HttpGet]
        public async Task<ActionResult> PegarCondominioPeloNomeAsync([FromQuery] string nomeCondominio)
        {
            var condominio = await _repositorio.PegarCondominioPeloNomeAsync(nomeCondominio);

            if(condominio.Count < 1) return NoContent();

            return Ok(condominio);
        }

        [HttpGet("bairro/{bairroCondominio}")]
        public async Task<ActionResult> PegarCondominioPeloBairroAsync([FromRoute] string bairroCondominio)
        {
            var condominio = await _repositorio.PegarCondominioPeloNomeAsync(bairroCondominio);

            if (condominio == null) return NoContent();

            return Ok(condominio);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> NovoCondominioAsync([FromBody] NovoCondominioDTO condominio)
        {
            if (!ModelState.IsValid) return BadRequest();
            try
            {
                await _repositorio.NovoCondominioAsync(condominio);
                return Ok();
            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }

        }
        #endregion Métodos
    }
}
