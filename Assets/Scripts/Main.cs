using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    static Main instance;
    static public Main Instance() { return instance; }
    List<GameObject> Wap = new List<GameObject>();
    List<Vector3> Vec = new List<Vector3>();
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()

    {
        for(int i =0; i < 5; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Debug.Log(Wap[i].GetType());
            Wap[i].transform.position = new Vector3(i * 2.0f, 0.0f, 0.0f);
            if (i > 0)
            {
                //Vec.Add(Wap[i-1].transform.position-Wap)
            }
        }
        for(int i =0; i <5; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Debug.Log(Wap[i+5].GetType());
            Wap[i+5].transform.position = new Vector3(i * 2.0f, 0.0f, 3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = ResourceManager.Instance().LoadObject("RedBall");
        }
        
    }
}
