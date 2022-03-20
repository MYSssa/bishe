using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgStart : DlgBase<DlgStart>
{

    private Button startBtn;
    void Awake()
    {
        instance = this;
        startBtn = GameObject.Find("startBtn").GetComponent<Button>();
    }
    void Start()
    {
        startBtn.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            DlgChoice.Instance.gameObject.SetActive(true);
        });
    }

    void Update()
    {

    }
}
