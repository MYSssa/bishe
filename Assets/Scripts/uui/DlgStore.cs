using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgStore : MonoBehaviour
{

    public static DlgStore instance;

    void Start()
    {
        instance = this;
        instance.gameObject.SetActive(false);

    }

    void Update()
    {

    }
}
