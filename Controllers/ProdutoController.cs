using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        Produto produto 
        = new Produto();

        ProdutoView produtoView 
        = new ProdutoView();
        
        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
            
        }

        //Pedimos para nosso modelo inserir as informações capturadas na View 
        public void Cadastrar(){
            produto.Inserir( produtoView.CadastrarProduto());
        }
    }
}