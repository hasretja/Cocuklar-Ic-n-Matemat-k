
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class raklamh : MonoBehaviour {
    private InterstitialAd reklamObjesi;
    public GameObject uto, utte;
    public GameObject galpbir, galpiki;
    public GameObject bosgalpbir, bosgalpiki;
    public GameObject uyari;
    public float hak;
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
        hak += 1;
        if (hak != PlayerPrefs.GetFloat("canaa"))
        {
            PlayerPrefs.SetFloat("canaa", hak);

        }
    }
    public void eksihakcontrol()
    {
        hak -= 1;
        if (hak != PlayerPrefs.GetFloat("canaa"))
        {
            PlayerPrefs.SetFloat("canaa", hak);

        }
    }
    void Update()
    {
        if (hak >= 3)
        {
            hak = 2;
        }
        if (PlayerPrefs.GetInt(gameObject.name) == 0)
        {
        }
        if (PlayerPrefs.GetInt(gameObject.name) != 0)
        {
            hak = PlayerPrefs.GetFloat("canaa");
        }
        if (PlayerPrefs.GetFloat("canaa") == 0)
        {
            uto.GetComponent<Button>().interactable = false;
            utte.GetComponent<Button>().interactable = false;
            galpbir.SetActive(false);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(true);
            bosgalpiki.SetActive(true);
            uyari.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("canaa") == 1)
        {
            uto.GetComponent<Button>().interactable = true;
            utte.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(true);
            uyari.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("canaa") == 2)
        {
            uto.GetComponent<Button>().interactable = true;
            utte.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(true);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(false);
            uyari.SetActive(false);
        }
    }
}
