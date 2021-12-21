using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    private Rigidbody mrb;
    public float fSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        mrb = gameObject.GetComponent<Rigidbody>();   
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    public void Spawn()
    {
        gameObject.SetActive(true);
    }
    public void Dead()
    {
        Destroy(this);
        gameObject.SetActive(false);
    }
    public void Move(Vector3 vec)
    {
        mrb.velocity = vec.normalized * fSpeed * Time.deltaTime;
    }
}
