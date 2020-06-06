//using LightInject;
//using ProjectHerculesService.Library.Interface;

//namespace ProjectHerculesService.IOC.DependencyContainer
//{
//    public class DependencyContainer : IDependencyContainer
//    {
//        /// <summary>
//        /// Get an instance of an object.
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <returns></returns>
//        public T GetInstance<T>() where T : class
//        {
//            return DependencyContainerInstance.Container.GetInstance<T>();
//        }

//        /// <summary>
//        /// Get a named instance of an object.
//        /// </summary>
//        /// <typeparam name="T"></typeparam>
//        /// <param name="name"></param>
//        /// <returns></returns>
//        public T GetInstance<T>(string name) where T : class
//        {
//            return DependencyContainerInstance.Container.GetInstance<T>(name);
//        }

//        /// <summary>
//        /// Register transient instance that is created on each request as in requested.
//        /// </summary>
//        /// <typeparam name="TFrom"></typeparam>
//        /// <typeparam name="TTo"></typeparam>
//        public static void Register<TFrom, TTo>() where TTo : TFrom
//        {
//            DependencyContainerInstance.Container.Register<TFrom, TTo>();
//        }

//        /// <summary>
//        /// Register transient instance that is created on each request as in requested.
//        /// </summary>
//        /// <typeparam name="TFrom"></typeparam>
//        /// <typeparam name="TTo"></typeparam>
//        public static void Register<TFrom, TTo>(string namedInstance) where TTo : TFrom
//        {
//            DependencyContainerInstance.Container.Register<TFrom, TTo>(namedInstance);
//        }

//        /// <summary>
//        /// Register scoped lifetime. Starts when the web request starts and end when the web request ends.  Will keep an instance for the life of the http request.
//        /// </summary>
//        /// <typeparam name="TFrom"></typeparam>
//        /// <typeparam name="TTo"></typeparam>
//        public static void RegisterScope<TFrom, TTo>() where TTo : TFrom
//        {
//            DependencyContainerInstance.Container.Register<TFrom, TTo>(new PerScopeLifetime());
//        }

//        /// <summary>
//        /// Register a singleton instance for life of container.
//        /// </summary>
//        /// <typeparam name="TFrom"></typeparam>
//        /// <typeparam name="TTo"></typeparam>
//        public static void RegisterSingleton<TFrom, TTo>() where TTo : TFrom
//        {
//            DependencyContainerInstance.Container.Register<TFrom, TTo>(new PerContainerLifetime());
//        }
//    }
//}