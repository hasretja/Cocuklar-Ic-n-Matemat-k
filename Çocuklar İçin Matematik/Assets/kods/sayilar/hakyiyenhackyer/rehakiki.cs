using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class rehakiki : MonoBehaviour
{
    private InterstitialAd reklamObjesi;
    public GameObject butons, buttone, butones;
    public GameObject galpbir, galpiki;
    public GameObject bosgalpbir, bosgalpiki;
    public GameObject mesaj;
    public float hakik;

    void Start()
    {
        MobileAds.Initialize("ca-app-pub-9927642697685217~5496367902");
    }
    public void reklamlar()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();

        reklamObjesi = new InterstitialAd("ca-app-pub-9927642697685217/5553499221");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);

        StartCoroutine(ReklamiGoster());
    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;

        reklamObjesi.Show();
    }
    public void hakcontrol()
    {
        hakik += 1;
        if (hakik != PlayerPrefs.GetFloat("hakkı4"))
        {
            PlayerPrefs.SetFloat("hakkı4", hakik);

        }
    }
    public void eksihakcontrol()
    {
        hakik -= 1;
        if (hakik != PlayerPrefs.GetFloat("hakkı4"))
        {
            PlayerPrefs.SetFloat("hakkı4", hakik);

        }
    }
    void Update()
    {
        if (hakik >= 3)
        {
            hakik = 2;
        }
        if (PlayerPrefs.GetInt(gameObject.name) == 0)
        {
        }
        if (PlayerPrefs.GetInt(gameObject.name) != 0)
        {
            hakik = PlayerPrefs.GetFloat("hakkı4");
        }
        if (PlayerPrefs.GetFloat("hakkı4") == 0)
        {
            butons.GetComponent<Button>().interactable = false;
            buttone.GetComponent<Button>().interactable = false;
            butones.GetComponent<Button>().interactable = false;
            galpbir.SetActive(false);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(true);
            bosgalpiki.SetActive(true);
            mesaj.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("hakkı4") == 1)
        {
            butons.GetComponent<Button>().interactable = true;
            buttone.GetComponent<Button>().interactable = true;
            butones.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(true);
            mesaj.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("hakkı4") == 2)
        {
            butons.GetComponent<Button>().interactable = true;
            buttone.GetComponent<Button>().interactable = true;
            butones.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(true);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(false);
            mesaj.SetActive(false);
        }
    }
}
