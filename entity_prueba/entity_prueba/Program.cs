using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace entity_prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using(AgenciaTransitoEntities db = new AgenciaTransitoEntities()){

                var lista = db.Agentes;
                /*
                                Agentes nuevo = new Agentes();
                                nuevo.Legajo = "A018";
                                nuevo.Apellidos = "richarlison2";
                                nuevo.Nombres = "egardito3";
                                nuevo.Email = "x@x.com";
                             //   DateTime DT2 = new DateTime(2019, 05, 09, 09, 15, 00);
                               // nuevo.FechaNacimiento = DT2;
                                //DateTime DT3 = new DateTime(2019, 06, 09, 09, 15, 00);

                //                nuevo.FechaIngreso = DT3;  


                                db.Agentes.Add(nuevo);
                                db.SaveChanges();
                */
                Agentes nuevardo = db.Agentes.Where(d => d.Nombres == "Carla").First();

                db.Agentes.Remove(nuevardo);
                db.SaveChanges();




                Console.ReadKey();


                foreach (var ag in lista)
                {

                    Console.WriteLine(ag.Apellidos);

                }
                Console.ReadKey();
            }

        }
    }
}
