using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    static ObjectPool minstance;
    static public ObjectPool Instance() { return minstance; }
    public List<GameObject> Wap = new List<GameObject>();
    public List<Vector3> Vec = new List<Vector3>();
    private void Awake()
    {
        minstance = this;
        for (int i = 0; i < 5; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Debug.Log(Wap[i].GetType());
            Wap[i].transform.position = new Vector3(-9 + i * 4.0f, 0.5f, 5.0f);
            if (i > 0)
            {
                Vec.Add(Wap[i - 1].transform.position - Wap[i].transform.position);
            }
        }
        for (int i = 5; i < 10; i++)
        {
            Wap.Add(ResourceManager.Instance().LoadObject("WayPoint"));
            Debug.Log(Wap[i].GetType());
            Wap[i].transform.position = new Vector3(-9 + (i - 5) * 4.0f, 0.5f, -5.0f);
            if (i > 5)
            {
                Vec.Add(Wap[i - 1].transform.position - Wap[i].transform.position);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject GetWayPoint(int i)
    {
        return Wap[i];
    }
}
