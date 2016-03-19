using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using LGroup.TemplateMethod.Model;
using LGroup.TemplateMethod.Business;

namespace LGroup.TemplateMethod.Test
{
    [TestFixture]
    public class ClienteTest
    {
        [Test]
        public void TestarClienteSemTemplate() {
            var cliente = new ClienteModel();
            cliente.Nome = "Zeh";
            cliente.Email = "aaa@ig.com.br";

            var negocio = new ClienteBusiness();
            

            //Sem o Template Method damos a liberdade dos desenvolvedores fazerem cagada
            //Aqui temos pelo menos 3 formas de errar
            //1- inverter os comandos - Cadastrar e depois Validar
            //2- Esquecer um dos comandos - Cadastrar ou Validar
            //3- Nao analisar o retorno do If

            //if (negocio.ValidarCamposObrigatorios(cliente)) {
            //    negocio.Cadastrar(cliente);
            //}
        }

        [Test]
        public void TestarClienteComTemplate() {
            var cliente = new ClienteModel();
            cliente.Nome = "Zeh";
            cliente.Email = "aaa@ig.com.br";

            var negocio = new ClienteBusiness();
            negocio.Execucao(cliente);
        
        }
    }
}
