using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using Unity.VisualScripting;
using UnityEngine;

public class Penguin_42 : MonoBehaviour
{

    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.position);

        // ������������
        transform.Translate(0.0f,0.0f,0.5f);

        // ����ł����������͎g�p�֎~��
        // transform.position += transform.TransformDirection(Vector3.forward) * 10.0f * Time.deltaTime;
    }
}
