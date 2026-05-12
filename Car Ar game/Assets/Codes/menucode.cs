using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menucode : MonoBehaviour
{
    public GameObject mainScreen;
    public Button[] baktiv;
    public GameObject[] aktiv;
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    public GameObject objectToSpawn3;
    public GameObject objectToSpawn4;
    public GameObject objectToSpawn5;
    public GameObject objectToSpawn6;
    public GameObject objectToSpawn7;
    public GameObject objectToSpawn8;
    public GameObject objectToSpawn9;
    public GameObject objectToSpawn10;
    public GameObject objectToSpawn11;
    public GameObject objectToSpawn12;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        aktiv[0].SetActive(true);
        baktiv[0].interactable = false;
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    public void profile()
    {
        mainScreen.SetActive(true);
    }
    public void profile2()
    {
        mainScreen.SetActive(false);
    }
    public void CarAcma(string isim)
    {
        for (int i = 0; i < baktiv.Length; i++)
        {
            baktiv[i].interactable = true;
        }
        for (int i = 0; i < aktiv.Length; i++)
        {
            aktiv[i].SetActive(false);
        }
        switch (isim)
        {
            case "k0":
                baktiv[0].interactable = false;
                aktiv[0].SetActive(true);
                break;
            case "k1":
                baktiv[1].interactable = false;
                aktiv[1].SetActive(true);
                break;
            case "k2":
                baktiv[2].interactable = false;
                aktiv[2].SetActive(true);
                break;
            case "k3":
                baktiv[3].interactable = false;
                aktiv[3].SetActive(true);
                break;
            case "k4":
                baktiv[4].interactable = false;
                aktiv[4].SetActive(true);
                break;
            case "k5":
                baktiv[5].interactable = false;
                aktiv[5].SetActive(true);
                break;
            case "k6":
                baktiv[6].interactable = false;
                aktiv[6].SetActive(true);
                break;
            case "k7":
                baktiv[7].interactable = false;
                aktiv[7].SetActive(true);
                break;
            case "k8":
                baktiv[8].interactable = false;
                aktiv[8].SetActive(true);
                break;
            case "k9":
                baktiv[9].interactable = false;
                aktiv[9].SetActive(true);
                break;
            case "k10":
                baktiv[10].interactable = false;
                aktiv[10].SetActive(true);
                break;
            case "k11":
                baktiv[11].interactable = false;
                aktiv[11].SetActive(true);
                break;
        }
    }
    public void Activate()
    {

        GameObject obj = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate2()
    {

        GameObject obj = Instantiate(objectToSpawn2,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate3()
    {

        GameObject obj = Instantiate(objectToSpawn3,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate4()
    {

        GameObject obj = Instantiate(objectToSpawn4,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate5()
    {

        GameObject obj = Instantiate(objectToSpawn5,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate6()
    {

        GameObject obj = Instantiate(objectToSpawn6,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate7()
    {

        GameObject obj = Instantiate(objectToSpawn7,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate8()
    {

        GameObject obj = Instantiate(objectToSpawn8,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate9()
    {

        GameObject obj = Instantiate(objectToSpawn9,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate10()
    {

        GameObject obj = Instantiate(objectToSpawn10,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate11()
    {

        GameObject obj = Instantiate(objectToSpawn11,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void Activate12()
    {

        GameObject obj = Instantiate(objectToSpawn12,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
    public void youtube()
    {
        Application.OpenURL("");
    }
    public void instagram()
    {
        Application.OpenURL("");
    }
    public void discord()
    {
        Application.OpenURL("");
    }
    public void CarArfoundation()
    {
        Application.OpenURL("");
    }
    public void FootballPlayers()
    {
        Application.OpenURL("");
    }
    public void sendfeedback()
    {
        Application.OpenURL("");
    }
}
