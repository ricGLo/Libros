using System.Collections.Immutable;
using Libros.Shared.Models ;

namespace Libros.Shared.Services;

public static class ProductProviderService
{
    public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>()
    {
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Cien años de soledad",
            Editorial = "Diana",
            ISBN = "978-6070728792",
            Edicion = 1,
            Precio = 199.90f,
            Imagen = "https://m.media-amazon.com/images/I/71YoFJSz3LL.jpg" 
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Ficciones",
            Editorial = "Debolsillo",
            ISBN = "978-6073104920",
            Edicion = 16,
            Precio = 229.0f,
            Imagen = "https://m.media-amazon.com/images/I/71oo7r184yL.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Las batallas en el desierto",
            Editorial = "Era",
            ISBN = "978-6074450552",
            Edicion = 3,
            Precio = 118.68f,
            Imagen = "https://m.media-amazon.com/images/I/71f+UzEuVJL.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "El amor en los tiempos del cólera",
            Editorial = "Diana",
            ISBN = "978-6070729164",
            Edicion = 1,
            Precio = 222.4f,
            Imagen = "https://m.media-amazon.com/images/I/81YPlYG-b9L.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Enayo sobre la seguera",
            Editorial = "Debolsillo",
            ISBN = "978-6073139113",
            Edicion = 1,
            Precio = 379.00f,
            Imagen = "https://m.media-amazon.com/images/I/717ZqBXBF9L.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "El principio del placer",
            Editorial = "Era",
            ISBN = "978-9684114104",
            Edicion = 1,
            Precio = 170.0f,
            Imagen = "https://m.media-amazon.com/images/I/41iH-7fIUEL.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Conversaciones en La Catedral",
            Editorial = "Alfaguara",
            ISBN = "978-6073187923",
            Edicion = 16,
            Precio = 367.20f,
            Imagen = "https://m.media-amazon.com/images/I/81r4rRFUAzL.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Rayuela",
            Editorial = "Penguin Random House Grupo",
            ISBN = "978-8420437484",
            Edicion = 16,
            Precio = 359.20f,
            Imagen = "https://m.media-amazon.com/images/I/71dbcFiDe6L.jpg"
        },
        new()
        {
            Id = Guid.NewGuid(),
            Titulo = "Aura",
            Editorial = "Era",
            ISBN = "978-6074451849",
            Edicion = 2,
            Precio = 114f,
            Imagen = "https://m.media-amazon.com/images/I/91omNHYaPIL.jpg"
        },
         new()
        {
            Id = Guid.NewGuid(),
            Titulo = "El Aleph",
            Editorial = "Debolsillo",
            ISBN = "978-6073104913",
            Edicion = 1,
            Precio = 301f,
            Imagen = "https://m.media-amazon.com/images/I/610Upk1dApL.jpg"
        }
    });
}