using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CSceneManager
{
    static private CSceneManager mInstance;
    public static CSceneManager Instance() { return mInstance; }
    // Start is called before the first frame update
    public CSceneManager()
    {
        mInstance = this;
    }
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
