using FactoryMethodApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach.Factories
{
    public class EntityCreator : IEntityCreator
    {
        public T Create<T>(params object[] paramters) where T : class, IEntity
        {
            return Activator.CreateInstance(typeof(T), paramters) as T;
        }
    }
}
