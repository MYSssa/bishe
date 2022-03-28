using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgSong : DlgBase<DlgSong>
{
    Button back;
    Button song1;
    RectTransform BG1;
    RectTransform BG2;
    Button back2;
    Button start;
    Dropdown sound;

    void Awake()
    {
        instance = this;
        back = GameObject.Find("back").GetComponent<Button>();
        back2 = GameObject.Find("back2").GetComponent<Button>();
        song1 = GameObject.Find("不可道").GetComponent<Button>();
        BG1 = GameObject.Find("BG1").GetComponent<RectTransform>();
        BG2 = GameObject.Find("BG2").GetComponent<RectTransform>();
        start = GameObject.Find("start").GetComponent<Button>();

    }

    void Start()
    {
        gameObject.SetActive(false);
        BG2.gameObject.SetActive(false);
        back.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgChoice.instance.gameObject.SetActive(true);
        });
        song1.onClick.AddListener(() =>
        {
            BG1.gameObject.SetActive(false);
            BG2.gameObject.SetActive(true);
        });
        back2.onClick.AddListener(() =>
        {
            BG2.gameObject.SetActive(false);
            BG1.gameObject.SetActive(true);
        });
        start.onClick.AddListener(() =>
        {
            BG2.gameObject.SetActive(false);
        });
    }

    void Update()
    {

    }
}
