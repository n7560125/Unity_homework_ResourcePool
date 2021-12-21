using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    static Main instance;
    static public Main Instance() { return instance; }
    List<GameObject> Wap = new List<GameObject>();

    private void Awake()
    {
        instance = this;
        for (int i = 0; i < 5; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Wap[i].transform.position = new Vector3(-9 + i * 4.0f, 0.5f, 5.0f);
            Debug.Log(Wap[i].transform.position);
            //if (i > 0)
            //{
            //    Vec.Add(Wap[i - 1].transform.position - Wap[i].transform.position);
            //}
        }
        for (int i = 5; i < 10; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Wap[i].transform.position = new Vector3(-9 + (i - 5) * 4.0f, 0.5f, -5.0f);
            Debug.Log(Wap[i].transform.position);
            //if (i > 5)
            //{
            //    Vec.Add(Wap[i - 1].transform.position - Wap[i].transform.position);
            //}
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = ResourceManager.Instance().LoadObject("RedBall");
            
        }
        
    }
    public GameObject GetWayPoint(int i)
    {
        return Wap[i];
    }
}
