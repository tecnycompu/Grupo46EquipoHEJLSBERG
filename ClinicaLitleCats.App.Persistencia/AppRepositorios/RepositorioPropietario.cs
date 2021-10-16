using System.Collections;
using System.Collections.Generic;
using ClinicaLitleCats.App.Dominio;
using System.Linq;



namespace ClinicaLitleCats.App.Persistencia
{
    public class RepositorioPropietario:IRepositorioPropietario
    {
        private readonly AppContext _appContext;
        public RepositorioPropietario(AppContext appContext) 
        {
            _appContext=appContext;
        }
        
        PropietarioEncargado IRepositorioPropietario.AddPropietario(PropietarioEncargado propietario)
        {
            var propietarioAdicionado =_appContext.PropietariosEncargados.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;      
        }
        PropietarioEncargado IRepositorioPropietario.UpdatePropietario(PropietarioEncargado Propietario)
        {
            var propietarioEncontrado=_appContext.PropietariosEncargados.FirstOrDefault(p=>p.Id==Propietario.Id);
            if(propietarioEncontrado!=null)
                {
                    propietarioEncontrado.DocumentoIdentidad=Propietario.DocumentoIdentidad;
                    propietarioEncontrado.Nombre=Propietario.Nombre;
                    propietarioEncontrado.Apellido=Propietario.Apellido;
                    propietarioEncontrado.Celular=Propietario.Celular;
                    propietarioEncontrado.Email=Propietario.Email;
                    propietarioEncontrado.Direccion=Propietario.Direccion;

                    _appContext.SaveChanges();

                }
                return propietarioEncontrado;



        }
        void IRepositorioPropietario.DeletePropietario(int DocumentoIdentidad)
        {
            var propietarioEncontrado =_appContext.PropietariosEncargados.FirstOrDefault(p=> p.Id ==DocumentoIdentidad);
            if (propietarioEncontrado==null)
                return;
            _appContext.PropietariosEncargados.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }
        PropietarioEncargado IRepositorioPropietario.GetPropietario(int DocumentoIdentidad)
        {
            return _appContext.PropietariosEncargados.FirstOrDefault(p => p.Id ==DocumentoIdentidad);           
        }

        IEnumerable<PropietarioEncargado> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.PropietariosEncargados;

        }

    }


}