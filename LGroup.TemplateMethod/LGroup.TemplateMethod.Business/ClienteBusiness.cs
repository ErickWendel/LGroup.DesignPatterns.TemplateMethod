using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.TemplateMethod.Model;

//antes de fazer qlqr Inserte, tem que seguir esse Fluxo
//Validar -> Cadastrar
namespace LGroup.TemplateMethod.Business
{
    public sealed class ClienteBusiness : Base.BaseBusiness<ClienteModel>
    {

        protected override bool ValidarCamposObrigatorios(ClienteModel registro_)
        {
            var retorno = true;

            if (registro_.Nome == "")
            {
                retorno = false;
            }
            else if (registro_.Email == "")
            {
                retorno = false;
            }

            return retorno;
        }

        protected override void Cadastrar(ClienteModel registro_)
        {
            throw new NotImplementedException();
        }
    }
}
