using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    internal interface IServiceProduct
    {

        Task AddProduct(Produto produto);
        Task Update(Produto produto);
    }
}
