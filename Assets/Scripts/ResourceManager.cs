using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    static ResourceManager minstance;
    static public ResourceManager Instance() { return minstance; }
    // Start is called before the first frame update
    private void Awake()
    {
        if (minstance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        minstance = this;
    }
    public GameObject LoadObject(string sPath)
    {
        Object o = Resources.Load(sPath);
        if (o == null)
        {
            return null;
        }
        GameObject go = Instantiate(o) as GameObject;
        return go;
    }
}
