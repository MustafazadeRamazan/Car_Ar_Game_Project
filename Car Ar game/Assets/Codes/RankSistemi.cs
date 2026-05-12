using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RankSistemi : MonoBehaviour
{

    public float puan, gereklipuan, kalanpuan, level, sonrakilevel, artipuan;
    public Text puanyazi, gereklipuanayazisi, kalanpuanyazi, levelyazi, sonrakilevelyazi;
    public GameObject exBar;

    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    public GameObject lock7;
    public GameObject lock8;
    public GameObject lock9;
    public GameObject lock10;
    public GameObject lock11;

    public float save;
    public float save2;
    public float save3;
    public GameObject IlkGiris;
    public GameObject rewardpanel;
    public GameObject attentionpanel;

    void Start()
    {
        puan = PlayerPrefs.GetFloat("Puanim");
        gereklipuan = PlayerPrefs.GetFloat("GerekliPuanim");
        level = PlayerPrefs.GetFloat("Levelim");
        save = PlayerPrefs.GetFloat("savecount");
        save2 = PlayerPrefs.GetFloat("savecount2");
        save3 = PlayerPrefs.GetFloat("savecount3");
    }

    void Update()
    {
        puanyazi.text = "" + puan;
        gereklipuanayazisi.text = "" + gereklipuan;
        kalanpuanyazi.text = "" + kalanpuan.ToString("00");
        levelyazi.text = level.ToString("");
        sonrakilevelyazi.text = sonrakilevel.ToString("");

        kalanpuan = gereklipuan - puan;
        sonrakilevel = level + 1;
        exBar.transform.localScale = new Vector3(puan / gereklipuan, 1, 1);

        PlayerPrefs.SetFloat("Puanim", puan);
        PlayerPrefs.SetFloat("GerekliPuanim", gereklipuan);
        PlayerPrefs.SetFloat("Levelim", level);
        PlayerPrefs.SetFloat("savecount", save);
        PlayerPrefs.SetFloat("savecount2", save2);
        PlayerPrefs.SetFloat("savecount3", save3);

        if (save == 1)
        {
            IlkGiris.SetActive(false);
        }
        if (save2 == 1)
        {
            rewardpanel.SetActive(false);
        }
        if (save3 == 1)
        {
            attentionpanel.SetActive(false);
        }

        if (puan > gereklipuan)
        {
            artipuan = puan - gereklipuan;
            puan = artipuan;
            level += 1;
            gereklipuan = level * 10;
        }
        if (level >= 10)
        {
            lock1.SetActive(false);
        }
        if (level >= 15)
        {
            lock2.SetActive(false);
        }
        if (level >= 20)
        {
            lock3.SetActive(false);
        }
        if (level >= 25)
        {
            lock4.SetActive(false);
        }
        if (level >= 30)
        {
            lock5.SetActive(false);
        }
        if (level >= 35)
        {
            lock6.SetActive(false);
        }
        if (level >= 40)
        {
            lock7.SetActive(false);
        }
        if (level >= 45)
        {
            lock8.SetActive(false);
        }
        if (level >= 50)
        {
            lock9.SetActive(false);
        }
        if (level >= 55)
        {
            lock10.SetActive(false);
        }
        if (level >= 60)
        {
            lock11.SetActive(false);
        }

    }
    public void ilkgiris()
    {
        save = 1;
        IlkGiris.SetActive(false);
        level = 1;
        puan = 1;
    }
    public void reward()
    {
        save2 = 1;
        rewardpanel.SetActive(false);
        level += 5;
        puan += 1;
    }
    public void GoogleArService()
    {
        save3 = 1;
        attentionpanel.SetActive(false);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.google.ar.core");
    }
}