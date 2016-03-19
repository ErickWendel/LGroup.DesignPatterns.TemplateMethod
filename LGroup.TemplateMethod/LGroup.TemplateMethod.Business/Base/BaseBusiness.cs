using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.TemplateMethod.Business.Base
{
    public abstract class BaseBusiness<TModelo>
    {
        //public abstract Boolean ValidarCamposObrigatorios(TModelo registro_);
        //public abstract void Cadastrar(TModelo registro_);

        //para implementar o padrao, mudaremos os metodos de public para protecd, deixando os metodos visiveis apenas nas classes filhas.
        //esta mudança deve ser extendia as classes que herdam da base

        protected abstract Boolean ValidarCamposObrigatorios(TModelo registro_);
        protected abstract void Cadastrar(TModelo registro_);

        //Padrao do Martin Fowler
        //a proposta do padrao, é garantir um fluxo de metodos, definindo uma sequencia a ser executada.

        //Implementação efetiva do Template Method

        public void Execucao(TModelo resgistro_)
        {
            if (ValidarCamposObrigatorios(resgistro_))
            {
                Cadastrar(resgistro_);
            }
        }
    }
}
