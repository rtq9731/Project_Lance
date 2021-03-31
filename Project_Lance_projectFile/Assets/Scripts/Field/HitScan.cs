using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HitScan : MonoBehaviour
{

    [SerializeField]
    [Header("맞았는지 검사할 오브젝트의 태그")]
    private string tagOfHitScanObject = "";
    [SerializeField]
    [Header("맞았는지 검사할 범위")]
    private float hitSacnRange = 0f;
    [SerializeField]
    [Header("이 오브젝트의 체력")]
    private float HP = 0f;
    [SerializeField]
    [Header("한번 피격 후 이 오브젝트의 무적시간")]
    private float notDieTime = 0;
    [SerializeField]
    [Header("맞은 후 이 캐릭터가 취할 행동")]
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

    private void HitScanOfThisObject() //TODO : 일관성있는 오브젝트들의 맞았을 시 행동 구현 필요
    {
        HP--;
        transform.DOShakePosition(0.1f, 0.5f);
        notDieTimer = 0;
    }

}
