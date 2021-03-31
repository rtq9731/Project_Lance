using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HitScan : MonoBehaviour
{

    [SerializeField]
    [Header("�¾Ҵ��� �˻��� ������Ʈ�� �±�")]
    private string tagOfHitScanObject = "";
    [SerializeField]
    [Header("�¾Ҵ��� �˻��� ����")]
    private float hitSacnRange = 0f;
    [SerializeField]
    [Header("�� ������Ʈ�� ü��")]
    private float HP = 0f;
    [SerializeField]
    [Header("�ѹ� �ǰ� �� �� ������Ʈ�� �����ð�")]
    private float notDieTime = 0;
    [SerializeField]
    [Header("���� �� �� ĳ���Ͱ� ���� �ൿ")]
    typeOfAct act;

    private enum typeOfAct{
        shake,
        die,
        fade,
        move,
    }

    private float notDieTimer = 0;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag(tagOfHitScanObject).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(target.position, transform.position) < hitSacnRange && notDieTimer > notDieTime)
        {
            HitScanOfThisObject();
        }

        notDieTimer += Time.deltaTime;
    }

    private void HitScanOfThisObject() //TODO : �ϰ����ִ� ������Ʈ���� �¾��� �� �ൿ ���� �ʿ�
    {
        HP--;
        transform.DOShakePosition(0.1f, 0.5f);
        notDieTimer = 0;
    }

}
