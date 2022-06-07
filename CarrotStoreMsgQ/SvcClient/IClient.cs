using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvcClient
{
    public interface IClient
    {
        Task GetAsync();

        Task PostAsync();

        Task PatchAsync();

        Task DeleteAsync();
    }
}
