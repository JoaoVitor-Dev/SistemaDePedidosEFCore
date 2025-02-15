﻿using EFCoreSistemaDePedidos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSistemaDePedidos.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodigoBarras { get; set; }
        public string? Descricao { get; set; }
        public Decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public Boolean Ativo { get; set; }
    }
}
