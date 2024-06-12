using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorTeste.ModuloCompartilhado
{
    public interface IControladorFiltravel
    {
        string ToolTipFiltrar { get; }
        
        void Filtrar();
    }
}
