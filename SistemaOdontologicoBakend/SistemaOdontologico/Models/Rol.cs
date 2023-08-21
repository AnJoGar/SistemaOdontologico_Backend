using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaOdontologico.Models
{
  public partial class Rol
  {
    public int Id { get; set; }
    public string? Descripcion { get; set; }    
    public DateTime? FechaRegistro { get; set; }
    public ICollection<Usuario> Usuarios { get; set; }= new List<Usuario>();
    public ICollection<MenuRol> MenuRols { get; set; } = new List<MenuRol>();
  }
}
