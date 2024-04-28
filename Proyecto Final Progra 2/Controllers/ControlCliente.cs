using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_Progra_2.Controllers.Models_Original;

namespace Proyecto_Final_Progra_2.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ControlCliente : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
            public dynamic listarClientes()
            {
            // aqui se puede colocar mas codigo
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    correo = "rtavo0705@gmail.com",
                    edad = "19",
                    nombre = "Gustavo Rodriguez Canales",
                },

                new Cliente
                {
                    id = "2",
                    correo = "rojas.mesen3920@gmail.com",
                    edad = "28",
                    nombre = "Karol Rojas Mesen",
                },

            };
            return clientes;
            }

        [HttpGet]
        [Route("listarxid")]
        public dynamic listarClientesXID(int codigo)
        {
            // aqui obtienes el cliente de la db


            return new Cliente
            {
                id = codigo.ToString(),
                correo = "rtavo0705@gmail.com",
                edad = "19",
                nombre = "Gustavo Rodriguez Canales",
            };

               

            
            
        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarClientes(Cliente cliente)
        {
            cliente.id = "3";
            return new
            {
                succes = true,
                message = "Cliente Registrado",
                Result = cliente
            };
        }
    }
}
