using System;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public GameObject mainCube;
    private int height;

    private void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x,height+1,transform.position.z);
        transform.localPosition = new Vector3(0, -height, 0);
    }
    public void HeihtDecrease()
    {
        height-=1;
    }
    // private void OnTriggerEnter(Collider other)
    //
    // {
    //     if (other.gameObject.tag == "pick"&&other.gameObject.GetComponent<StackCube>().GetHasItGathered()==false)
    //     {
    //         height+=1;
    //         other.gameObject.GetComponent<StackCube>().SetHasItGathered();
    //         other.gameObject.GetComponent<StackCube>().SetIndex(height);
    //         other.gameObject.transform.parent = mainCube.transform;
    //     }
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "StackZero"&&collision.gameObject.GetComponent<StackCube>().GetHasItGathered()==false)
        {
            height+=1;
            collision.gameObject.GetComponent<StackCube>().SetHasItGathered();
            collision.gameObject.GetComponent<StackCube>().SetIndex(height);
            collision.gameObject.transform.parent = mainCube.transform;
            // Vector3 desPos=mainCube.transform.position;
            // desPos.y += 0.1f;
            // collision.gameObject.transform.localPosition = desPos;
        }    
    }
}