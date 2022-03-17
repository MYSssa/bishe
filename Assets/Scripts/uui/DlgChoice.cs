using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgChoice : MonoBehaviour
{

    public static DlgChoice instance;
    private Button song;
    private Button store;
    private Button setting;
    private Button my;
    void Awake()
    {
        song = GameObject.Find("song").GetComponent<Button>();
        store = GameObject.Find("store").GetComponent<Button>();
        setting = GameObject.Find("setting").GetComponent<Button>();
        my = GameObject.Find("my").GetComponent<Button>();
    }
    void Start()
    {
        instance = this;
        instance.gameObject.SetActive(false);

        song.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgSong.instance.gameObject.SetActive(true);
        });
        store.onClick.AddListener(() =>
        {
            instance.gameObject.SetActive(false);
            DlgStore.instance.gameObject.SetActive(true);
        });
        //setting.onClick.AddListener(() =>
        //{
        //    dlgs.instance.gameObject.SetActive(true);
        //});
        //my.onClick.AddListener(() =>
        //{
        //    DlgSong.instance.gameObject.SetActive(true);
        //});
    }

    void Update()
    {

    }
}
