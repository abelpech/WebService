using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

//Add Library

using FacturacionLibrary.DAL;
using FacturacionLibrary.Business_Objects;


namespace FacturacionWebService
{
    /// <summary>
    /// Summary description for WSFacturacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class WSFacturacion : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Cliente> ConsultaCliente(Int32? IdCliente)
        {
            List<Cliente> ClientList = new List<Cliente>();
            try
            {
                ClientList = ClienteDAL.ConsultaCliente(IdCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return ClientList;
        }

        [WebMethod]
        public Int32 InsertarCliente(Cliente client)
        {
            int affectedRows = 0;
            try
            {
                affectedRows = ClienteDAL.InsertarCliente(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return affectedRows;
        }

        [WebMethod]
        public Int32 ActualizaCliente(Cliente client)
        {
            int affectedRows = 0;
            try
            {
                affectedRows = ClienteDAL.ActualizaCliente(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return affectedRows;
        }

        [WebMethod]
        public Int32 BorrarCliente(Cliente client)
        {
            int affectedRows = 0;
            try
            {
                affectedRows = ClienteDAL.BorrarCliente(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return affectedRows;
        }

        [WebMethod]
        public double Square(double x)
        {
            return x * x;
        }
    }
}
