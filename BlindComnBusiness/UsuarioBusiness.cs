using BlindConmDao;
using BlindConmEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindComnBusiness
{
    public class UsuarioBusiness
    {
        UsuarioDao Dao = new UsuarioDao(); 
        public bool AdicionarUsuario(Usuario usuario)
        {
            try
            {
                bool adicionou = Dao.AdicionarUsuario(usuario);
                return adicionou;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ListarUsuarios(Usuario usuario)
        {
            try
            {
                List<Usuario> usuarios = Dao.ListarUsuarios(usuario);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletarUsuario (int idUsuario)
        {
            try
            {
                bool deletado = Dao.DeletarUsuario(idUsuario);
                return deletado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool DeletarUsuario (string racf)
        {
            try
            {
                bool deletado = Dao.DeletarUsuario(0,racf);
                return deletado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateUsuario (Usuario usuario)
        {
            try
            {
                bool efetuado = Dao.UpdateUsuario(usuario);
                return efetuado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
