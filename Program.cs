﻿using System;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<string> cidades=new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Curitiba");
            cidades.Add("Osasco");
            cidades.Add("Manaus");

            Console.WriteLine(cidades[1].ToUpper());
            
            //#####################################################################

            List<Usuarios> us=new List<Usuarios>();
            Usuarios lucas = new Usuarios(){Id=35,Login="lucas",Senha="12345"};
            Usuarios tuanny = new Usuarios(){Id=10,Login="tuanny",Senha="12"};

            us.Add(lucas);
            us.Add(tuanny);

            Console.WriteLine(us[0].Login);
            Console.WriteLine(lucas.Login);
            */

            //########################################

            List<Produto> sacola = new List<Produto>();

            HigienePessoal sabonete = new HigienePessoal();
            sabonete.Id = 10;
            sabonete.Marca="Dove";
            sabonete.NumeroMS="12345";
            sabonete.Preco = 20;

            Bebidas cerveja = new Bebidas();
            cerveja.Id = 10;
            cerveja.Nome = "Skol";
            cerveja.TeorAlcolico = 6.5;
            cerveja.Tipo = "Alcolica";

            sacola.Add(cerveja);
            sacola.Add(sabonete);

            CW

            foreach(var item in sacola)
            {
                string classe = item.GetType().ToString();
                switch (classe)
                {
                    case "ExemploLista.HigienePessoal":
                    {
                        HigienePessoal higiene = (HigienePessoal)item;
                        Console.WriteLine("Higiene Pessoal: "+ higiene.Nome + " - " + higiene.Marca);
                        break;
                    }
                    case "ExemploLista.Bebidas":
                    {
                        Bebidas bebida = (Bebidas)item;
                        Console.WriteLine("Bebidas: "+ bebida.Nome + " - " + bebida.TeorAlcolico);
                        break;
                    }
                }
            }

        }
    }
}
