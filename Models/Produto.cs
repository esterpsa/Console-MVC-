using System.IO;
using System;
using System.Collections.Generic;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH 
        = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split('/')[0];

            //verificamos que a pasta não existe e criamos essa condição
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);

            //Verificamos se o arquivo Produto.CSV existe, caso não existe vamos cria-lo
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            }
        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            //Pegar as informações do csv
            string [] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas){
            
            //Separar atributo pelo :
            string[] atributos = item.Split(';');

            Produto prod    = new Produto();
            prod.Codigo     = int.Parse(atributos[0]);
            prod.Nome       = atributos[1];
            prod.Preco      = float.Parse(atributos[2]);

            produtos.Add(prod);

            }

            return produtos;
        }

        
        
        
        
        
        
    }
}