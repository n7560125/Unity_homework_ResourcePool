using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public Rigidbody mrb;
    public GameObject currentTarget;
    public float fSpeed;
    private int x = 1;
    // Start is called before the first frame update
    private void Awake()
    {
        mrb = gameObject.GetComponent<Rigidbody>();
        currentTarget = Main.Instance().GetWayPoint(0);

    }
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Move(currentTarget);
        Debug.Log(currentTarget.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == gameObject.name)
        {
            return;
        }
        if (x == 10)
        {
            gameObject.SetActive(false);
        }
        currentTarget = Main.Instance().GetWayPoint(x);
        x ++;
    }
    public void Spawn(Vector3 start, Vector3 target)
    {
        gameObject.SetActive(true);
        transform.position = start;
        transform.forward = target - start;
    }
    public void Dead()
    {
        Destroy(this);
        gameObject.SetActive(false);
    }
    public void Move(GameObject target)
    {
        Vector3 vec = target.transform.position - transform.position;
        vec.y = 0.0f;
        vec.Normalize();
        transform.position = transform.position + vec * fSpeed * Time.deltaTime;
    }
}
