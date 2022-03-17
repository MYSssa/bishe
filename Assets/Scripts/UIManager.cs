using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Canvas UGUI;
    private RectTransform DlgStart;
    private RectTransform DlgChoice;
    private RectTransform DlgSong;
    private RectTransform DlgStore;
    //private RectTransform DlgStart;

    void Start()
    {
        UGUI = gameObject.GetComponent<Canvas>();

        Instantiate(Resources.Load("ui/DlgStart"), UGUI.transform);
        Instantiate(Resources.Load("ui/DlgChoice"), UGUI.transform);
        Instantiate(Resources.Load("ui/DlgSong"), UGUI.transform);
        Instantiate(Resources.Load("ui/DlgStore"), UGUI.transform);
    }


    void Update()
    {

    }
}
