using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startpoint;
    public Transform[] path;

    [SerializeField] private Button StartButton;

    private void Awake()
    {
        main = this;
    }


      

}
