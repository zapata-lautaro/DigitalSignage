﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;

namespace DAL
{

    /// <summary>
    /// Repositorio generico para el acceso a las campañas
    /// </summary>
    public interface ICampaignRepository : IRepository<Campaign>
    {
    }
}