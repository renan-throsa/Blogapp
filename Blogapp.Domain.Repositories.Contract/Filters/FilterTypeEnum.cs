using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogapp.Domain.IRepositories.Filters
{
    public enum FilterTypeEnum
    {
        Equal,
        Like,
        Maior,
        MaiorIgual,
        Menor,
        MenorIgual,
        IsNull,
        De,
        Ate,
        NotEqual,
        PeriodoContemData
    }
}
