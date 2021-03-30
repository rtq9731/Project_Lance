using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    private bool isMove = false;

    [SerializeField] [Header("�ִ� �ӵ�")]
    private float maxSpeed = 0;

    [SerializeField] [Header("�ӵ�")]
    private float speed = 0;

    [SerializeField] [Header("���ӵ�")]
    private float speedHC;

    [SerializeField] [Header("ȸ���ӵ�")]
    private float rotationspeed = 1;

    public float Speed
    {
        get { return speed; }
        private set { speed = value; }
    }

    void Update()
    {

        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            if (speed >= maxSpeed)
                speed = 10;

            speed += speedHC;
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (speed <= speedHC)
                speed = 0;
            
            speed -= speedHC;
        }

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, 0, -10) * rotationspeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0, 0, 10) * rotationspeed * Time.deltaTime);

    }

}
