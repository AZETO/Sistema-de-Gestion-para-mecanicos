// See https://aka.ms/new-console-template for more information
using ProyectoTalleresMecanicos.Molde;




Console.WriteLine("----------Catalogo Talleres-------------");
Console.WriteLine("");

Mecanico mecanico = new Mecanico(); //Clase Administrador

mecanico.Mecanico_taller = "Los Remaches";
mecanico.Mecanico_nombre = "Sergio";
mecanico.Mecanico_direccion = "Capitan Avalos 2684";
mecanico.Mecanico_correo = "soytumecanico@gmail.com";
mecanico.Mecanico_telefono = 945138542;

Console.WriteLine("Nombre de Taller:" + mecanico.Mecanico_taller);
Thread.Sleep(800); //Thread


Console.WriteLine("Nombre:" + mecanico.Mecanico_nombre);
Thread.Sleep(800); //Thread

Console.WriteLine("Direccion:" + mecanico.Mecanico_direccion);
Thread.Sleep(800); //Thread

Console.WriteLine("Correo:" + mecanico.Mecanico_correo);
Thread.Sleep(800); //Thread

Console.WriteLine("Telefono:" + mecanico.Mecanico_telefono);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");

Console.WriteLine("----------Catalogos-------------");
Console.WriteLine("");

Catalogos catalogo = new Catalogos (); //Clase Administrador

catalogo.Catalogo_nombretallercatalogo = "Los Remaches";
catalogo.Catalogo_producto = "Catalogo Productos";



Console.WriteLine("Nombre de Taller:" + catalogo.Catalogo_nombretallercatalogo);
Thread.Sleep(800); //Thread


Console.WriteLine("Productos:" + catalogo.Catalogo_producto);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");

Catalogoproducto  catalogop = new Catalogoproducto(); //Clase Administrador

catalogop.Catalogoproducto_id = 1;
catalogop.Catalogoproducto_nombre = "Bomba de freno";
catalogop.Catalogoproducto_precio = "33.100";
catalogop.Catalogoproducto_stock = "3";

Console.WriteLine("Id:" + catalogop.Catalogoproducto_id);
Thread.Sleep(800); //Thread


Console.WriteLine("Nombre:" + catalogop.Catalogoproducto_nombre);
Thread.Sleep(800); //Thread

Console.WriteLine("Valor:" + catalogop.Catalogoproducto_precio);
Thread.Sleep(800); //Thread

Console.WriteLine("Stock:" + catalogop.Catalogoproducto_stock);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");






Catalogos catalogo1 = new Catalogos(); //Clase Administrador

catalogo1.Catalogo_nombretallercatalogo = "Los Remaches";
catalogo1.Catalogo_servicio = "servicios";

Console.WriteLine("Servicios:" + catalogo1.Catalogo_servicio);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");

Catalogoservicio catalogop1 = new Catalogoservicio (); //Clase Administrador

catalogop1.Catalogoservicio_id = 1;
catalogop1.Catalogoservicio_agenda = "fecha de cita";


Console.WriteLine("Id:" + catalogop1.Catalogoservicio_id);
Thread.Sleep(800); //Thread


Console.WriteLine("Agenda de servicio:" + catalogop1.Catalogoservicio_agenda);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");







Console.WriteLine("");
Console.WriteLine("------------------------------------------");

Mecanico mecanico2 = new Mecanico(); //Clase Administrador

mecanico2.Mecanico_taller = "El taller de Billy";
mecanico2.Mecanico_nombre = "Pepe";
mecanico2.Mecanico_direccion = "Capitan Avalos 2272";
mecanico2.Mecanico_correo = "mecanicamortal@gmail.com";
mecanico2.Mecanico_telefono = 926839832;

Console.WriteLine("Nombre de Taller:" + mecanico2.Mecanico_taller);
Thread.Sleep(800); //Thread


Console.WriteLine("Nombre:" + mecanico2.Mecanico_nombre);
Thread.Sleep(800); //Thread

Console.WriteLine("Direccion:" + mecanico2.Mecanico_direccion);
Thread.Sleep(800); //Thread

Console.WriteLine("Correo:" + mecanico2.Mecanico_correo);
Thread.Sleep(800); //Thread

Console.WriteLine("Telefono:" + mecanico2.Mecanico_telefono);
Thread.Sleep(800); //Thread

Console.WriteLine("");


Console.WriteLine("----------Catalogos-------------");
Console.WriteLine("");

Catalogos catalogo2 = new Catalogos(); //Clase Administrador

catalogo2.Catalogo_nombretallercatalogo = "El taller de Billy";
catalogo2.Catalogo_producto = "Catalogo Productos";



Console.WriteLine("Nombre de Taller:" + catalogo2.Catalogo_nombretallercatalogo);
Thread.Sleep(800); //Thread


Console.WriteLine("Productos:" + catalogo2.Catalogo_producto);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");

Catalogoproducto catalogop2 = new Catalogoproducto(); //Clase Administrador

catalogop2.Catalogoproducto_id = 2;
catalogop2.Catalogoproducto_nombre = "Tapa de ruedas aro 14";
catalogop2.Catalogoproducto_precio = "6.400";
catalogop2.Catalogoproducto_stock = "4";

Console.WriteLine("Id:" + catalogop2.Catalogoproducto_id);
Thread.Sleep(800); //Thread


Console.WriteLine("Nombre:" + catalogop2.Catalogoproducto_nombre);
Thread.Sleep(800); //Thread

Console.WriteLine("Valor:" + catalogop2.Catalogoproducto_precio);
Thread.Sleep(800); //Thread

Console.WriteLine("Stock:" + catalogop2.Catalogoproducto_stock);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");






Catalogos catalogo22 = new Catalogos(); //Clase Administrador

catalogo22.Catalogo_nombretallercatalogo = "Los Remaches";
catalogo22.Catalogo_servicio = "servicios";

Console.WriteLine("Servicios:" + catalogo22.Catalogo_servicio);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");

Catalogoservicio catalogop22 = new Catalogoservicio(); //Clase Administrador

catalogop22.Catalogoservicio_id = 2;
catalogop22.Catalogoservicio_agenda = "fecha de cita";


Console.WriteLine("Id:" + catalogop22.Catalogoservicio_id);
Thread.Sleep(800); //Thread


Console.WriteLine("Agenda de servicio:" + catalogop22.Catalogoservicio_agenda);
Thread.Sleep(800); //Thread

Console.WriteLine("------------------------------------------");
Console.WriteLine("");