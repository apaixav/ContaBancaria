﻿using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Repository
{
    public interface IContaRepository
    {

        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        public void Sacar(int numero, decimal valor);
        public void Depositar(int numeroOrigem, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);
    }
}
