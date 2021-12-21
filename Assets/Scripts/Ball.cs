using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    public GameObject wp1;
    public GameObject wp2;
    public GameObject wp3;
    public Rigidbody mrb;
    public float fSpeed;
    private Vector3 vec1;
    // Start is called before the first frame update
    void Start()
    {
        Transform wt1 = wp1.transform;
        Transform wt2 = wp2.transform;
        Transform wt3 = wp3.transform;
        gameObject.SetActive(false);
        Vector3 vec1 = wt1.position - start.transform.position;
        Vector3 vec2 = wt2.position - wt1.position;
        Vector3 vec3 = wt3.position - wt2.position;
        Vector3 vec4 = end.transform.position - wt3.position;
        vec1.Normalize();
        mrb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        mrb.velocity = vec1 * fSpeed * Time.deltaTime;
    }
    public void Spawn()
    {
        gameObject.SetActive(true);
        gameObject.transform.position = start.transform.position;
    }
    public void Dead()
    {
        Destroy(this);
        gameObject.SetActive(false);
    }
}
