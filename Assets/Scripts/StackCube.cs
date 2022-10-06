using System;
using UnityEngine;

public class StackCube : MonoBehaviour
{
    public StackManager stackManager;
    private bool hasItGathered;
    private int index;
    
    void Update()
    {
        if (hasItGathered == true)
        {
            if (transform.parent!=null)
            {
                transform.localPosition = new Vector3(0, -index, 0);

            }
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "barrier")
    //     {
    //         stackManager.HeihtDecrease();
    //         gameObject.transform.parent = null;
    //         // gameObject.GetComponent<BoxCollider>().enabled = false;
    //         other.gameObject.GetComponent<BoxCollider>().enabled = false;
    //         gameObject.GetComponent<Collider>().isTrigger = false;
    //     }
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Barrier")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false; 
            stackManager.HeihtDecrease();
            gameObject.transform.parent = null;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<Collider>().isTrigger = false;
        }
    }

    public bool GetHasItGathered()
    {
        return hasItGathered;
    }

    public void SetHasItGathered()
    {
        hasItGathered = true;
    }

    public void SetIndex(int index)
    {
        this.index = index;
    }
    
}