﻿using DDD.Domain.AtividadeAulaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface IEstadoService
    {
        
        List<Estado> GetEstado();
        Estado GetEstadoById(int id);
       

    }
}
