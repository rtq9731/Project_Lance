using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{

    public static FieldManager Instance = null;

    private PlayerScript player = null;

    public PlayerScript Player
    { get; private set; }
    public float SpeedOfPlayer
    { get { return player.Speed; } private set { return; } }

    private float hp = 0;
    public float HP
    {
        get { return hp; }
        set { hp = value; }
    }

    void Awake()
    {
        Instance = this;
        player = FindObjectOfType<PlayerScript>();
        SpeedOfPlayer = player.Speed;
    }
    private void OnDestroy()
    {
        Instance = null;
    }

}
