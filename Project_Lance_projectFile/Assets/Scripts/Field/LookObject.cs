using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookObject : MonoBehaviour
{

    [SerializeField] [Header("오프셋 조정을 위한 변수")]
    private float offset = 0;
    [SerializeField] [Header("바라볼 대상의 태그")]
    private string tagOfLookingObject = "";

    private Transform target;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag(tagOfLookingObject).GetComponent<Transform>();
    }

    void Update()
    {
        Lookat();
    }

    private void Lookat()
    {
        targetPos = target.position;
        thisPos = transform.position;
        targetPos.x = targetPos.x - thisPos.x;
        targetPos.y = targetPos.y - thisPos.y;
        angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
    }
}
