using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoIntegrador.Composite
{
    public interface IILuminable
    {
        void revisarYcambiarLamparasQuemadas();

        void Add(IILuminable iluminable);
    }
}
