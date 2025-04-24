using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteFolhaDePagamento
{
    public class RepositorioFuncionario
    {
        /* Classe responsável pelo armazenamento dos dados dos funcionarios,
         * assim como os métodos para 
         * manutenção e acesso a eles. */

        private IList<Funcionario> funcionarios = new 
            BindingList<Funcionario>(); //Armazena os funcionarios.

        public void Inserir(Funcionario funcionario)
        {
            funcionarios.Add(funcionario); //Adiciona um novo funcionario a lista.
        }

        public IList<Funcionario> ObterTodos()
        {
            return this.funcionarios; //Retorna todos os funcionarios da lista.
        }
    }
}
