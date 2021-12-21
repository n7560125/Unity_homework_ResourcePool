using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    static SceneChange minstance;
    static public SceneChange Instance()
    {
        return minstance;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        minstance = this;
        CSceneManager cs = new CSceneManager();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            CSceneManager.Instance().ChangeScene("GameScene");
        }
    }
}
