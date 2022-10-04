using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBase : MonoBehaviour
{
    //�����Ă��鐯
    private int _star;

    //�X�^�[�̐���\������e�L�X�g
    private Text _starNomberText;
    void Start()
    {
        _starNomberText = GameObject.Find("StarNomberText").GetComponent<Text>();

        StarGet();
        StarDisPlay();
    }

    //���̐���ۑ�����
    public void StarSave()
    {
        PlayerPrefs.SetInt("Star", _star);
    }
    //�����Ăяo��
    public void StarGet()
    {
        _star = PlayerPrefs.GetInt("Star",0);
    }
    //���̐����ʂ�
    public void StarDisPlay()
    {
        _starNomberText.text = "���~" + _star;
    }
    //�������
    public void StageStarGet(int StageStar)
    {
        _star += StageStar;
    }
}
