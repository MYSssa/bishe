using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgMy : DlgBase<DlgMy>
{

    Button back;
    RectTransform scoreView;
    Text name_X;
    Text score_X;
    Text name2_X;

    void Awake()
    {
        instance = this;
        back = GameObject.Find("back").GetComponent<Button>();
        scoreView = GameObject.Find("scoreView").GetComponent<RectTransform>();
        name_X = GameObject.Find("name_X").GetComponent<Text>();
        score_X = GameObject.Find("score_X").GetComponent<Text>();
        name2_X = GameObject.Find("name2_X").GetComponent<Text>();
    }
    void Start()
    {
        gameObject.SetActive(false);

        back.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgChoice.instance.gameObject.SetActive(true);
        });
    }

    void Update()
    {

    }
}
