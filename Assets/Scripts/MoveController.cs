using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float hiz;
    [SerializeField] private float sagaSolaHiz;
    

    void Update()
    {
        float yatayHiz = Input.GetAxis("Horizontal") * sagaSolaHiz * Time.deltaTime;
        this.transform.Translate(hiz*Time.deltaTime,0,-yatayHiz);
    }
}
