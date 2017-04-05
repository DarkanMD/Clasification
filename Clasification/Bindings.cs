using System;
using Ninject.Modules;

namespace Clasification
{
    class Bindings : NinjectModule
    {
        private static readonly Bindings instance = new Clasification.Bindings();

        static Bindings()
        {
        }

        private Bindings()
        {
        }

        public static Bindings Instance
        {
            get
            {
                return instance;
            }
        }

        public override void Load()
        {
            Bind<IFactory<Product>>().To<ProductFactory>();
            Bind<IFactory<User>>().To<UserFactory>();
        }
    }
}
