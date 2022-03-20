using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgStore : DlgBase<DlgStore>
{
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        gameObject.SetActive(false);

    }

    void Update()
    {

    }
}
