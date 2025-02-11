using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Producto> lista = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop", Descripcion = "Laptop potente", Precio = 1200, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 5, 10) },
            new Producto { Id = 2, Nombre = "Mouse", Descripcion = "Mouse óptico", Precio = 25, Stock = 50, Categoria = "Informática", FechaCreacion = new DateTime(2023, 6, 1) },
            new Producto { Id = 3, Nombre = "Teclado", Descripcion = "Teclado mecánico", Precio = 80, Stock = 30, Categoria = "Informática", FechaCreacion = new DateTime(2023, 4, 20) },
            new Producto { Id = 4, Nombre = "Monitor", Descripcion = "Monitor Full HD", Precio = 300, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 3, 15) },
            new Producto { Id = 5, Nombre = "Auriculares", Descripcion = "Auriculares Bluetooth", Precio = 150, Stock = 40, Categoria = "Audio", FechaCreacion = new DateTime(2023, 7, 5) },
            new Producto { Id = 6, Nombre = "Cámara", Descripcion = "Cámara profesional", Precio = 900, Stock = 5, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 2, 10) },
            new Producto { Id = 7, Nombre = "Tablet", Descripcion = "Tablet con pantalla retina", Precio = 600, Stock = 25, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 8, 12) },
            new Producto { Id = 8, Nombre = "Disco Duro", Descripcion = "Disco duro externo 1TB", Precio = 100, Stock = 35, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 1, 8) },
            new Producto { Id = 9, Nombre = "Router", Descripcion = "Router WiFi 6", Precio = 200, Stock = 10, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 6, 30) },
            new Producto { Id = 10, Nombre = "Impresora", Descripcion = "Impresora láser", Precio = 250, Stock = 18, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 5, 25) },
            new Producto { Id = 11, Nombre = "Proyector", Descripcion = "Proyector 4K", Precio = 1000, Stock = 12, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 5, 15) },
            new Producto { Id = 12, Nombre = "Altavoces", Descripcion = "Altavoces Bluetooth", Precio = 80, Stock = 22, Categoria = "Audio", FechaCreacion = new DateTime(2023, 6, 3) },
            new Producto { Id = 13, Nombre = "Teclado Bluetooth", Descripcion = "Teclado inalámbrico", Precio = 90, Stock = 40, Categoria = "Informática", FechaCreacion = new DateTime(2023, 7, 7) },
            new Producto { Id = 14, Nombre = "Micrófono", Descripcion = "Micrófono USB", Precio = 120, Stock = 50, Categoria = "Audio", FechaCreacion = new DateTime(2023, 8, 19) },
            new Producto { Id = 15, Nombre = "Smartwatch", Descripcion = "Reloj inteligente", Precio = 250, Stock = 45, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 2, 2) },
            new Producto { Id = 16, Nombre = "Silla de oficina", Descripcion = "Silla ergonómica", Precio = 220, Stock = 28, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 6, 17) },
            new Producto { Id = 17, Nombre = "Escritorio", Descripcion = "Escritorio moderno", Precio = 150, Stock = 35, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 4, 28) },
            new Producto { Id = 18, Nombre = "Laptop Gamer", Descripcion = "Laptop para videojuegos", Precio = 2000, Stock = 5, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 7, 10) },
            new Producto { Id = 19, Nombre = "Cargador portátil", Descripcion = "Cargador de batería externa", Precio = 30, Stock = 60, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 9, 5) },
            new Producto { Id = 20, Nombre = "Gafas VR", Descripcion = "Gafas de realidad virtual", Precio = 500, Stock = 12, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 5, 13) },
            new Producto { Id = 21, Nombre = "Bocinas", Descripcion = "Bocinas de alta calidad", Precio = 350, Stock = 20, Categoria = "Audio", FechaCreacion = new DateTime(2023, 6, 25) },
            new Producto { Id = 22, Nombre = "Pantalla", Descripcion = "Pantalla curva 144Hz", Precio = 400, Stock = 18, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 7, 22) },
            new Producto { Id = 23, Nombre = "Micrófono de condensador", Descripcion = "Micrófono de estudio", Precio = 150, Stock = 25, Categoria = "Audio", FechaCreacion = new DateTime(2023, 8, 3) },
            new Producto { Id = 24, Nombre = "Monitor Curvo", Descripcion = "Monitor ultra ancho", Precio = 350, Stock = 14, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 9, 12) },
            new Producto { Id = 25, Nombre = "Teclado mecánico RGB", Descripcion = "Teclado con retroiluminación", Precio = 110, Stock = 28, Categoria = "Informática", FechaCreacion = new DateTime(2023, 3, 18) },
            new Producto { Id = 26, Nombre = "Mouse inalámbrico", Descripcion = "Mouse ergonómico", Precio = 40, Stock = 50, Categoria = "Informática", FechaCreacion = new DateTime(2023, 5, 22) },
            new Producto { Id = 27, Nombre = "Tercera pantalla", Descripcion = "Pantalla adicional para trabajo", Precio = 200, Stock = 15, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 8, 16) },
            new Producto { Id = 28, Nombre = "Silla Gamer", Descripcion = "Silla para videojuegos", Precio = 180, Stock = 10, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 7, 30) },
            new Producto { Id = 29, Nombre = "Cargador inalámbrico", Descripcion = "Cargador sin cables", Precio = 35, Stock = 45, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 9, 8) },
            new Producto { Id = 30, Nombre = "Tablet de dibujo", Descripcion = "Tableta gráfica para diseño", Precio = 400, Stock = 20, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 6, 12) },
            new Producto { Id = 31, Nombre = "Silla ergonómica", Descripcion = "Silla ajustable", Precio = 160, Stock = 30, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 4, 10) },
            new Producto { Id = 32, Nombre = "Auriculares Gaming", Descripcion = "Auriculares con sonido envolvente", Precio = 100, Stock = 50, Categoria = "Audio", FechaCreacion = new DateTime(2023, 5, 18) },
            new Producto { Id = 33, Nombre = "Estación de trabajo", Descripcion = "Estación de trabajo multiusos", Precio = 500, Stock = 25, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 8, 28) },
            new Producto { Id = 34, Nombre = "Proyector portátil", Descripcion = "Proyector compacto", Precio = 250, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 9, 19) },
            new Producto { Id = 35, Nombre = "Disco SSD", Descripcion = "Disco sólido para computadoras", Precio = 120, Stock = 40, Categoria = "Almacenamiento", FechaCreacion = new DateTime(2023, 7, 14) },
            new Producto { Id = 36, Nombre = "Tablet Android", Descripcion = "Tablet Android con pantalla 10 pulgadas", Precio = 350, Stock = 30, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 6, 28) },
            new Producto { Id = 37, Nombre = "Lente fotográfico", Descripcion = "Lente para cámaras DSLR", Precio = 450, Stock = 10, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 5, 8) },
            new Producto { Id = 38, Nombre = "Cámara deportiva", Descripcion = "Cámara para deportes extremos", Precio = 250, Stock = 35, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 3, 24) },
            new Producto { Id = 39, Nombre = "Auriculares con cancelación de ruido", Descripcion = "Auriculares para aislamiento de sonido", Precio = 180, Stock = 50, Categoria = "Audio", FechaCreacion = new DateTime(2023, 4, 5) },
            new Producto { Id = 40, Nombre = "Cámara instantánea", Descripcion = "Cámara para fotos instantáneas", Precio = 120, Stock = 20, Categoria = "Fotografía", FechaCreacion = new DateTime(2023, 8, 21) },
            new Producto { Id = 41, Nombre = "Smart TV", Descripcion = "Televisor inteligente 55 pulgadas", Precio = 800, Stock = 15, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 5, 30) },
            new Producto { Id = 42, Nombre = "Reloj de pulsera", Descripcion = "Reloj analógico", Precio = 75, Stock = 60, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 7, 15) },
            new Producto { Id = 43, Nombre = "Cámara de seguridad", Descripcion = "Cámara para vigilancia", Precio = 150, Stock = 25, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 6, 22) },
            new Producto { Id = 44, Nombre = "Batería externa", Descripcion = "Batería de litio para móviles", Precio = 40, Stock = 50, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 8, 5) },
            new Producto { Id = 45, Nombre = "Parlantes inteligentes", Descripcion = "Parlantes con asistente de voz", Precio = 120, Stock = 30, Categoria = "Audio", FechaCreacion = new DateTime(2023, 4, 12) },
            new Producto { Id = 46, Nombre = "Cargador solar", Descripcion = "Cargador portátil solar", Precio = 60, Stock = 18, Categoria = "Electrónica", FechaCreacion = new DateTime(2023, 9, 10) },
            new Producto { Id = 47, Nombre = "Silla de juego", Descripcion = "Silla para gamer con reposabrazos ajustables", Precio = 220, Stock = 12, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 8, 18) },
            new Producto { Id = 48, Nombre = "Cable HDMI", Descripcion = "Cable HDMI de 2 metros", Precio = 15, Stock = 70, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 6, 15) },
            new Producto { Id = 49, Nombre = "Soporte para monitor", Descripcion = "Soporte ajustable para monitor", Precio = 40, Stock = 25, Categoria = "Oficina", FechaCreacion = new DateTime(2023, 5, 5) },
            new Producto { Id = 50, Nombre = "Mochila para laptop", Descripcion = "Mochila con compartimento para laptop", Precio = 50, Stock = 45, Categoria = "Accesorios", FechaCreacion = new DateTime(2023, 7, 20) },

        };

        Console.WriteLine("Productos en stock:");

        //1. Todos los productos 
        foreach (var producto in lista)
        {
            Console.WriteLine($"Nombre: {producto.Nombre}");

        }

        //2. Nombre de todos los produtos
        Console.WriteLine("\nNombres de todos los productos:");
        var nombresProductos = lista.Select(p => p.Nombre);
        foreach (var nombre in nombresProductos)
        {
            Console.WriteLine(nombre);
        }

        //3. Productos cuyo precio es mayor a 500

        Console.WriteLine("\nProductos precio mayor a 500:");
        var productoMas500 = lista.Where(p => p.Precio > 500);
        foreach (var precio in productoMas500)
        {
            Console.WriteLine($" {precio.Nombre} ");
        }

        //4. Obtener los productos con stock menor a 10.
        Console.WriteLine("\nProductos con stock menor a 10:");
        var stockMenos10 = lista.Where(p => p.Stock < 10);
        foreach (var producto in stockMenos10)
        {
            Console.WriteLine($" {producto.Nombre} - Stock: {producto.Stock}");
        }

        //5. Obtener los productos de la categoría "Electrónica.
        Console.WriteLine("\nProductos de la categoria electronica:");
        var productosElectronica = lista.Where(p => p.Categoria == "Electrónica");
        foreach (var producto in productosElectronica)
        {
            Console.WriteLine($" {producto.Nombre} - {producto.Categoria}");
        }
        //6.Obtener los productos cuyo nombre empiece con la letra "L"
        Console.WriteLine("\nProductos cuyos nombres empiezan con la letra L:");
        var productosLetraL = lista.Where(p => p.Nombre.StartsWith("L"));
        foreach (var producto in productosLetraL)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        //7. btener los productos cuyo precio esté entre 100 y 500.
        Console.WriteLine("\nProductos cuyos precios esten entre 100 y 500:");
        var productosPrecioPromedio = lista.Where(p => p.Precio >= 100 && p.Precio <= 500);
        foreach (var producto in productosPrecioPromedio)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 8. Obtener los productos ordenados por precio ascendente
        Console.WriteLine("\nProductos ordenados de menor a mayor segun el precio:");
        var productosAscendentes = lista.OrderBy(p => p.Precio);
        foreach (var producto in productosAscendentes)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 9. Obtener los productos ordenados por precio descendente.
        Console.WriteLine("\nProductos ordenados de mayor a menor segun el precio:");
        var productosDescendientes = lista.OrderByDescending(p => p.Precio);
        foreach (var producto in productosDescendientes)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 10. Obtener los productos ordenados por nombre en orden alfabético.
        Console.WriteLine("\nProductos ordenados en orden alfabetico:");
        var productosAlfabeticos = lista.OrderBy(p => p.Nombre);
        foreach (var producto in productosAlfabeticos)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        // 11. Obtener los productos ordenados por stock de mayor a menor.
        Console.WriteLine("\nProductos ordenados de menor a mayor segun el stock:");
        var productosStockAscendente = lista.OrderBy(p => p.Stock);
        foreach (var producto in productosStockAscendente)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Stock}");
        }

        // 12. Obtener los primeros 5 productos más caros.
        Console.WriteLine("\nPrimeros 5 productos ordenados mas caros:");
        var productosMasCaros = lista.OrderByDescending(p => p.Precio).Take(5);
        foreach (var producto in productosMasCaros)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 13. Obtener los 10 productos con menor stock.
        Console.WriteLine("\n10 productos con menos stock:");
        var productos10MenosStocke = lista.OrderByDescending(p => p.Stock).Take(10);
        foreach (var producto in productos10MenosStocke)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Stock}");
        }

        // 14. Obtener la cantidad total de productos en la lista.

        Console.WriteLine("\nProductos total en la lista:");
        Console.WriteLine($"Total Productos: {lista.Count}");

        // 15. Obtener la suma de todos los precios de los productos.
        Console.WriteLine("\nSuma total de precios:");
        var sumaPrecios = lista.Sum(p => p.Precio);
        Console.WriteLine($"Suma de precios: ${sumaPrecios}");


        // 16. Obtener el precio promedio de los productos
        Console.WriteLine("\nPrecio promedio de los productos:");
        var precioPromedio = lista.Average(p => p.Precio);
        Console.WriteLine($"Precio promedio: ${precioPromedio}");

        // 17. Obtener el producto más caro.
        Console.WriteLine("\nProducto mas caro:");
        var productosMasCaro = lista.OrderByDescending(p => p.Precio).Take(1);
        foreach (var producto in productosMasCaro)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 18. Obtener el producto más barato
        Console.WriteLine("\nProducto mas barato:");
        var productosMasBarato = lista.OrderBy(p => p.Precio).Take(1);
        foreach (var producto in productosMasBarato)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
        }

        // 19. Verificar si hay algún producto con precio mayor a 1000.
        Console.WriteLine("\nProducto mayor a 1000:");
        var productosMayor1000 = lista.Any(p => p.Precio > 1000);
        Console.WriteLine(productosMayor1000 ? "Sí, hay productos caros." : "No, no hay productos caros.");

        // 20. Verificar si todos los productos tienen stock mayor a 5.
        Console.WriteLine("\nProducto Stock mayor a 5:");
        var productosStockMayor5 = lista.Any(p => p.Stock > 5);
        Console.WriteLine(productosStockMayor5 ? "Sí, todos los productos tienen stock mayor a 5." : "No, no todos los productos tienen stock mayor a 5.");

        // 21. Contar cuántos productos hay en la categoría "Audio".
        Console.WriteLine("\nProducto Stock categoria Audio:");
        var productoCategoriaAudio = lista.Where(p => p.Categoria == "Audio");
        foreach (var producto in productoCategoriaAudio)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        // 22. Agrupar los productos por categoría.
        Console.WriteLine("\nProductos por categoria:");
        var productoCategoria = lista.GroupBy(p => p.Categoria);
        foreach (var grupo in productoCategoria)
        {
            Console.WriteLine($"{grupo.Key}:");
            foreach (var producto in grupo)
            {
                Console.WriteLine($"- {producto.Nombre} ");
            }
        }
        // 23. Obtener la categoría con más productos.
        Console.WriteLine("\nCategoria con mas productos:");
        var cactegoriaMasProductos = lista.GroupBy(p => p.Categoria)
                                             .OrderByDescending(g => g.Count())
                                             .First();
        Console.WriteLine($"Categoría con más productos: {cactegoriaMasProductos.Key} con {cactegoriaMasProductos.Count()} productos.");

        // 24. Obtener el stock total de todos los productos.
        Console.WriteLine("\nStock total de todos los productos:");
        var stockTotal = lista.Sum(p => p.Stock);
        Console.WriteLine($"Stock Total: {stockTotal}");

        // 25. Obtener el producto con el nombre más largo.
        Console.WriteLine("\nProducto con el nombre mas largo:");
        var NombreLargo = lista.OrderByDescending(p => p.Nombre.Length).First();
        Console.WriteLine($"{NombreLargo.Nombre} - {NombreLargo.Nombre.Length} caracteres");

        // 26. Obtener el producto con la descripción más corta.
        Console.WriteLine("\nProducto con descripcion mas corta:");
        var descripcionCorta = lista.OrderByDescending(p => p.Descripcion.Length).First();
        Console.WriteLine($"{descripcionCorta.Descripcion} - {descripcionCorta.Descripcion.Length} caracteres");

        // 27. Filtrar los productos cuya descripción contenga la palabra "pantalla".
        Console.WriteLine("\nProductos cuya descripción contenga la palabra pantalla:");
        var productosPantalla = lista.Where(p => p.Descripcion.Contains("Pantalla"));
        foreach (var producto in productosPantalla)
        {
            Console.WriteLine($" Descripcion: {producto.Nombre} - {producto.Descripcion}");
        }

        // 28. Obtener el promedio de stock de los productos de la categoría "Almacenamiento".

        Console.WriteLine("\nPromedio stock almacenamiento:");
        var stockAlmacenamiento = lista.Where(p => p.Categoria == "Almacenamiento").Average(p => p.Stock);
        Console.WriteLine($"Promedio en stock de la categoria almacenamiento: ${stockAlmacenamiento}");

        // 29. Obtener los productos creados en una fecha específica (20/12/2022).
        var productosFecha = lista.Where(p => p.FechaCreacion.Date == new DateTime(2022, 12, 20));
        foreach (var producto in productosFecha)
        {
            Console.WriteLine($"{producto.Nombre} - {producto.FechaCreacion.ToShortDateString()}");
        }

        // 30. Obtener los productos cuya ID sea par.
        Console.WriteLine("\nProductos cuya ID sea par:");
        var productosIdPar = lista.Where(p => p.Id % 2 == 0);
        foreach (var producto in productosIdPar)
        {
            Console.WriteLine($"{producto.Nombre} - ID:{producto.Id}");
        }

        // 31. Obtener los productos cuya ID sea impar
        Console.WriteLine("\nProductos cuya ID sea impar:");
        var productosIdImpar = lista.Where(p => p.Id % 2 != 0);
        foreach (var producto in productosIdImpar)
        {
            Console.WriteLine($"{producto.Nombre} - ID:{producto.Id}");
        }

        // 32. Obtener los productos cuyo precio tenga un decimal mayor a 50
        var productosPrecioDecimalMayor = lista.Where(p => p.Precio % 1 > 0.5m);
        foreach (var producto in productosPrecioDecimalMayor)
        {
            Console.WriteLine($"{producto.Nombre} - ${producto.Precio}");
        }
        // 33. Obtener los productos cuyo nombre tenga más de 10 caracteres
        Console.WriteLine("\nProducto con los nombres con mas de 10 caracteres:");
        var productosNombreLargo = lista.Where(p => p.Nombre.Length > 10);
        foreach (var producto in productosNombreLargo)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        // 34. Obtener los productos cuyo stock sea un número primo.

        Console.WriteLine("\nProductos cuyo stock sea un número primo:");
        var productosStockPrimo = lista.Where(p => EsNumeroPrimo(p.Stock));
        foreach (var producto in productosStockPrimo)
        {
            Console.WriteLine($"{producto.Nombre} - Stock: {producto.Stock}");
        }

        // 35. Obtener los productos cuyo nombre contenga la palabra "Pro".
        Console.WriteLine("\nProductos cuyo nombre contenga la palabra Pro");
        var productosPro = lista.Where(p => p.Nombre.Contains("Pro"));
        foreach (var producto in productosPro)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        // 36. Obtener los productos cuyo stock sea un múltiplo de 5.


        Console.WriteLine("\nProductos cuyos stock son multiplo de 5");
        var productosMultiplo5 = lista.Where(p => p.Stock % 5 == 0);
        foreach (var producto in productosMultiplo5)
        {
            Console.WriteLine($"{producto.Nombre} - Stock: {producto.Stock}");
        }

        // 37. Obtener los productos que tengan una descripción con más de 20 caracteres.
        Console.WriteLine("\nProducto con descripcion de mas de 20 caracteres:");
        var productosMas20Caracteres = lista.Where(p => p.Descripcion.Length > 20);
        foreach (var producto in productosMas20Caracteres)
        {
            Console.WriteLine($"{producto.Nombre}-{producto.Descripcion}");
        }

        //38.Obtener los productos cuyo precio sea un número redondo(sin decimales).
        var productosPrecioRedondo = lista.Where(p => p.Precio % 1 == 0);
        foreach (var producto in productosPrecioRedondo)
        {
            Console.WriteLine($"{producto.Nombre} - ${producto.Precio}");
        }
        // 39. Obtener los productos que tengan exactamente dos palabras en su nombre.

        Console.WriteLine("\nProductos con exactamente dos palabras en su nombre:");
        var productosDosPalabras = lista.Where(p => p.Nombre.Split(' ').Length == 2);
        foreach (var producto in productosDosPalabras)
        {
            Console.WriteLine($"{producto.Nombre}");
        }

        // 40. Obtener la cantidad de productos que no pertenecen a la categoría "General"
        Console.WriteLine("\nEjercicio 40: Productos que no pertenecen a la categoría 'General':");
        var productosNoGeneral = lista.Where(p => p.Categoria != "General");
        foreach (var producto in productosNoGeneral)
        {
            Console.WriteLine($"{producto.Nombre}");
        }
    }


    private static bool EsNumeroPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}