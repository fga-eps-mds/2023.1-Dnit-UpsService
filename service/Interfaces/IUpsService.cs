﻿using dominio;
using System.Collections.Generic;

namespace service.Interfaces
{
    public interface IUpsService
    {
        public IEnumerable<Sinistro> ObterSinistros();
        public void CalcularUpsEmMassa();
        public UpsDetalhado CalcularUpsEscola(Escola escola);
        public double CalcularDistancia(double lat1, double long1, double lat2, double long2);
    }
}
