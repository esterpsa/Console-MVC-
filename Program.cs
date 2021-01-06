using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)

        {
            //Istancimos o nosso Controller
            ProdutoController produtoController = new ProdutoController();

            produtoController.MostrarProdutos();
        }
    }
}
