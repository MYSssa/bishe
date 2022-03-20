using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgCharacter : DlgBase<DlgCharacter>
{
    Button back;

    void Awake()
    {
        instance = this;
        back = GameObject.Find("back").GetComponent<Button>();
    }
    void Start()
    {
        back.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgChoice.instance.gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
