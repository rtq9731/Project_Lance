using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{

    public static FieldManager Instance = null;

    private PlayerScript player = null;

    public PlayerScript Player
    { get; private set; }

    void Awake()
    {
        Instance = this;
        player = FindObjectOfType<PlayerScript>();

    }
    private void OnDestroy()
    {
        Instance = null;
    }

}
