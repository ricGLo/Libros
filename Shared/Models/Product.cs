using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libros.Shared.Models;

public class Product
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }  = "";
    public string Editorial { get; set; }  = "";
    public string ISBN { get; set; }  = "";
    public int Edicion { get; set; } 
    public float Precio { get; set; }
    public string Imagen { get; set; }  = "";
}