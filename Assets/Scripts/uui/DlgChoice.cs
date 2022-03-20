using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgChoice : DlgBase<DlgChoice>
{

    private Button song;
    private Button store;
    private Button character;
    private Button my;
    void Awake()
    {
        instance = this;
        song = GameObject.Find("song").GetComponent<Button>();
        store = GameObject.Find("store").GetComponent<Button>();
        character = GameObject.Find("character").GetComponent<Button>();
        my = GameObject.Find("my").GetComponent<Button>();
    }
    void Start()
    {
        gameObject.SetActive(false);

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
        character.onClick.AddListener(() =>
        {
            DlgCharacter.instance.gameObject.SetActive(true);
        });
        my.onClick.AddListener(() =>
        {
            DlgMy.instance.gameObject.SetActive(true);
        });
    }

    void Update()
    {

    }
}
