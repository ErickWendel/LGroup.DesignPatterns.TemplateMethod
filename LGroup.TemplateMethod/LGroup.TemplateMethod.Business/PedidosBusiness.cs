using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.TemplateMethod.Model;

namespace LGroup.TemplateMethod.Business
{
    public sealed class PedidosBusiness : Base.BaseBusiness<PedidoModel>
    {
        protected override bool ValidarCamposObrigatorios(PedidoModel registro_)
        {
            var retorno = true;

            if (registro_.CodigoCliente == 0)
            {
                retorno = false;
            }
            else if (registro_.Valor == 0)
            {
                retorno = false;
            }

            return retorno;
        }

        protected override void Cadastrar(PedidoModel registro_)
        {
            throw new NotImplementedException();
        }
    }
}
