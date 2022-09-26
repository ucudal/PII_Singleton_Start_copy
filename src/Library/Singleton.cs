using System;

namespace Library
{
    public class Singleton<T> where T : new()
    {
        private static T instance;
        public static T GetInstance()  //metodo
        {
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}