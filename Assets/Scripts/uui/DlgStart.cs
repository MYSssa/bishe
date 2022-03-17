using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgStart : MonoBehaviour
{

    private Button startBtn;
    public static DlgStart instance;
    void Start()
    {
        instance = this;
        startBtn = GameObject.Find("startBtn").GetComponent<Button>();
        startBtn.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgChoice.instance.gameObject.SetActive(true);
        });
    }

    void Update()
    {

    }
}
