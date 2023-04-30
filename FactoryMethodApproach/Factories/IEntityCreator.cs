using FactoryMethodApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach.Factories
{
    public interface IEntityCreator
    {
        T Create<T>(params object[] paramsArray) where T : class, IEntity;
    }
}
