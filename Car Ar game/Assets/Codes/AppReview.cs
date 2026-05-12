using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppReview : MonoBehaviour
{
    public GameObject ReviewPanel;
    public string yaddasaxla;

    void Start()
    {
        yaddasaxla = PlayerPrefs.GetString("review");
    }

    public void StartReview()
    {
        if (yaddasaxla == "reviewpage")
        {
            ReviewPanel.SetActive(false);
        }
        else
        {
            ReviewPanel.SetActive(true);
        }
    }

    public void CloseReview()
    {
        yaddasaxla = "reviewpage";
        PlayerPrefs.SetString("review", yaddasaxla);
        ReviewPanel.SetActive(false);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.NinjaGamer.CarArFoundation&hl=en&gl=US");
    }
}