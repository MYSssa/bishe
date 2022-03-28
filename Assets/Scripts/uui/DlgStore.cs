using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgStore : DlgBase<DlgStore>
{
    Button back;
    Button back1;
    Button back2;
    Button back3;
    Button back4;
    Button 青鸟衔风;
    Button 栖凰;
    Button 水叙湖风;
    Button 补天裂;
    Button saber1;
    Button saber2;
    Button saber3;
    Button saber4;
    Button bg6;
    Button bg7;
    Button bg8;
    Button bg9;
    Button bg10;
    Button bg11;
    Button buyBtn;
    Image buyObjImg;
    Text money;
    Transform song;
    Transform saber;
    Transform bg;
    Transform checkBuy;
    Button songBtn;
    Button saberBtn;
    Button bgBtn;
    Text ownMoneyText;

    void Awake()
    {
        instance = this;
        back = GameObject.Find("back").GetComponent<Button>();
        back1 = GameObject.Find("back1").GetComponent<Button>();
        back2 = GameObject.Find("back2").GetComponent<Button>();
        back3 = GameObject.Find("back3").GetComponent<Button>();
        back4 = GameObject.Find("back4").GetComponent<Button>();
        青鸟衔风 = GameObject.Find("青鸟衔风").GetComponent<Button>();
        栖凰 = GameObject.Find("栖凰").GetComponent<Button>();
        水叙湖风 = GameObject.Find("水叙湖风").GetComponent<Button>();
        补天裂 = GameObject.Find("补天裂").GetComponent<Button>();
        saber1 = GameObject.Find("saber1").GetComponent<Button>();
        saber2 = GameObject.Find("saber2").GetComponent<Button>();
        saber3 = GameObject.Find("saber3").GetComponent<Button>();
        saber4 = GameObject.Find("saber4").GetComponent<Button>();
        bg6 = GameObject.Find("bg6").GetComponent<Button>();
        bg7 = GameObject.Find("bg7").GetComponent<Button>();
        bg8 = GameObject.Find("bg8").GetComponent<Button>();
        bg9 = GameObject.Find("bg9").GetComponent<Button>();
        bg10 = GameObject.Find("bg10").GetComponent<Button>();
        bg11 = GameObject.Find("bg11").GetComponent<Button>();
        buyBtn = GameObject.Find("buyBtn").GetComponent<Button>();
        buyObjImg = GameObject.Find("buyObjImg").GetComponent<Image>();
        money = GameObject.Find("money").GetComponent<Text>();
        songBtn=GameObject.Find("songBtn").GetComponent<Button>();
        saberBtn= GameObject.Find("saberBtn").GetComponent<Button>();
        bgBtn= GameObject.Find("bgBtn").GetComponent<Button>();
        ownMoneyText = GameObject.Find("ownMoneyText").GetComponent<Text>();

    }
    void Start()
    {
        song.gameObject.SetActive(false);
        saber.gameObject.SetActive(false);
        bg.gameObject.SetActive(false);
        checkBuy.gameObject.SetActive(false);
        gameObject.SetActive(false);

        #region 返回按钮
        back.onClick.AddListener(() => {
            gameObject.SetActive(false);
        });
        back1.onClick.AddListener(() => {
            song.gameObject.SetActive(false);
        });
        back2.onClick.AddListener(() => {
            saber.gameObject.SetActive(false);
        });
        back3.onClick.AddListener(() => {
            bg.gameObject.SetActive(false);
        });
        back4.onClick.AddListener(() => {
            checkBuy.gameObject.SetActive(false);
        });
        #endregion

        #region 点开详情
        songBtn.onClick.AddListener(() => {
            song.gameObject.SetActive(true);
        });
        saberBtn.onClick.AddListener(() => {
            saber.gameObject.SetActive(true);
        });
        bgBtn.onClick.AddListener(() => {
            bg.gameObject.SetActive(true);
        });
        #endregion
    }

    void Update()
    {

    }
    /// <summary>
    /// 更新积分
    /// </summary>
    void UpdateMoney()
    {
        //ownMoneyText.text = "积分:" + 读取xml;
    }
}
