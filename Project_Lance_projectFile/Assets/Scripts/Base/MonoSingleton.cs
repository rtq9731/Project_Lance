using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool isShutDown = false;

    private static object locker = new object();

    private static T instance;
    public static T Instance
    {
        get
        {

            if(isShutDown)
            {
                return null;
            }

            lock(locker)
            {
                if (!instance)
                {
                    instance = (T)FindObjectOfType(typeof(T));
                    if (!instance)
                    {
                        GameObject temp = new GameObject(typeof(T).ToString());
                        instance = temp.AddComponent<T>();
                    }

                    DontDestroyOnLoad(instance);
                }
            }

            return instance;
        }
    }

    private void OnApplicationQuit()
    {
        isShutDown = true;
    }
    private void OnDestroy()
    {
        isShutDown = true;
    }

}
