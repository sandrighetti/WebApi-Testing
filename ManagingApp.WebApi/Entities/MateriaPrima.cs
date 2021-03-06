﻿using System.Collections.Generic;
using ManagingApp.WebApi.Enums;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Entities
{
    public class MateriaPrima : BaseEntity, IProduto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
        public AgrupamentoProduto Grupo { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; } = new List<Fornecedor>();

        protected MateriaPrima()
        {
        }

        public MateriaPrima(long id, string descricao, double valor, int estoque, AgrupamentoProduto grupo, UnidadeMedida unidadeMedida)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Estoque = estoque;
            Grupo = grupo;
            UnidadeMedida = unidadeMedida;
        }

        public void AddSupplier(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }

        public void RemoveSupplier(Fornecedor fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }
    }
}
