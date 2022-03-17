using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgSong : MonoBehaviour
{

    public static DlgSong instance;

    void Start()
    {
        instance = this;
        instance.gameObject.SetActive(false);

    }

    void Update()
    {

    }
}
