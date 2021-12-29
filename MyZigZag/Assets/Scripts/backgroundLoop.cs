using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundLoop : MonoBehaviour
{
    public static backgroundLoop instanse;
    private void Awake()
    {
        if(instanse == null)
        {
            instanse = this;
        }
        else if(instanse != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
