﻿using AvaliaçãoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoFinal.Repositories
{
    public class UsuarioRepository

    {
        private static List<Usuario> usuarios;   
        private static int contador = 1;

        public UsuarioRepository()
        {
         
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();


           
                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "asd",
                    sobrenome = "abc",
                    senha = "1234",
                    data = "04-05-2000",
                    usuario = "evitelli"
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 2,
                    nome = "abc",
                    sobrenome = "dadad",
                    senha = "1234",
                    data = "02-03-1999",
                    usuario = "ccc"
                }
                );
                contador++;
            }
        }
      
        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }
        
        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }
     
        public void editar(Usuario usuario)
        {

           
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

     
        public void deletar(int codigo)
        {
        
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);

            
            usuarios.Remove(usuario);
        }
    }
}
