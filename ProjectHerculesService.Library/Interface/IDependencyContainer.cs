namespace ProjectHerculesService.Library.Interface
{
    public interface IDependencyContainer
    {
        /// <summary>
        /// Get an instance of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetInstance<T>() where T : class;

        /// <summary>
        /// Get a named instance of an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        T GetInstance<T>(string name) where T : class;
    }
}