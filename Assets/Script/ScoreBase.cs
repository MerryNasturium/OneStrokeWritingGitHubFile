using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBase : MonoBehaviour
{
    //持っている星
    private int _star;

    //スターの数を表示するテキスト
    private Text _starNomberText;
    void Start()
    {
        _starNomberText = GameObject.Find("StarNomberText").GetComponent<Text>();

        StarGet();
        StarDisPlay();
    }

    //星の数を保存する
    public void StarSave()
    {
        PlayerPrefs.SetInt("Star", _star);
    }
    //星を呼び出す
    public void StarGet()
    {
        _star = PlayerPrefs.GetInt("Star",0);
    }
    //星の数を写す
    public void StarDisPlay()
    {
        _starNomberText.text = "★×" + _star;
    }
    //星を入手
    public void StageStarGet(int StageStar)
    {
        _star += StageStar;
    }
}
