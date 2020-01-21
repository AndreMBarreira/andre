﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao.Entidades
{
    class Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
