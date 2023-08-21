using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaOdontologico.Repositorios.Contratos;
using SistemaOdontologico.DTO;
using SistemaOdontologico.Utilidades;
using SistemaOdontologico.Repositorios.Interfaces;
using SistemaOdontologico.Repositorios.Implementacion;
using AutoMapper;

namespace SistemaOdontologico.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuarioController : ControllerBase
  {
    private readonly IUsuarioRepository _UsuarioServicios;
    public UsuarioController(IUsuarioRepository usuarioServicios)
    {
      _UsuarioServicios = usuarioServicios;
    }

    [HttpPost]
    [Route("IniciarSesion")]
    public async Task<IActionResult> IniciarSesion([FromBody] LoginDTO login)
    {
      var rsp = new Response<SesionDTO>();
      try
      {
        rsp.status = true;
        rsp.value = await _UsuarioServicios.ValidarCredenciales(login.Correo,login.Clave);
      }
      catch (Exception ex)
      {
        rsp.status = false;
        rsp.msg = ex.Message;
      }
      return Ok(rsp);
    }

    [HttpGet]
    [Route("Lista")]
    public async Task<IActionResult> Lista()
    {
      var rsp = new Response<List<UsuarioDTO>>();
      try
      {
        rsp.status = true;
        rsp.value = await _UsuarioServicios.listaUsuarios();
      }
      catch (Exception ex)
      {
        rsp.status = false;
        rsp.msg = ex.Message;
      }
      return Ok(rsp);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioDTO>> GetById(int id)
    {
      try
      {
        var odontologo = await _UsuarioServicios.obtenerPorIdUsuario(id);
        if (odontologo == null)
          return NotFound();
        return Ok(odontologo);
      }
      catch
      {
        return StatusCode(500, "Error al obtener el Odontólogo por ID");
      }
    }

    [HttpPost]
    [Route("Guardar")]
    public async Task<IActionResult> Guardar([FromBody] UsuarioDTO usuario)
    {
      var rsp = new Response<UsuarioDTO>();
      try
      {
        rsp.status = true;
        rsp.value = await _UsuarioServicios.crearUsuario(usuario);
      }
      catch (Exception ex)
      {
        rsp.status = false;
        rsp.msg = ex.Message;
      }
      return Ok(rsp);
    }

    [HttpPut]
    [Route("Editar")]
    public async Task<IActionResult> Editar([FromBody] UsuarioDTO Usuario)
    {
      var rsp = new Response<bool>();
      try
      {
        rsp.status = true;
        rsp.value = await _UsuarioServicios.editarUsuario(Usuario);
      }
      catch (Exception ex)
      {
        rsp.status = false;
        rsp.msg = ex.Message;
      }
      return Ok(rsp);
    }

    [HttpDelete]
    [Route("Eliminar/{id:int}")]
    public async Task<IActionResult> Eliminar(int id)
    {
      var rsp = new Response<bool>();
      try
      {
        rsp.status = true;
        rsp.value = await _UsuarioServicios.eliminarUsuario(id);
      }
      catch (Exception ex)
      {
        rsp.status = false;
        rsp.msg = ex.Message;
      }
      return Ok(rsp);
    }
  }
}