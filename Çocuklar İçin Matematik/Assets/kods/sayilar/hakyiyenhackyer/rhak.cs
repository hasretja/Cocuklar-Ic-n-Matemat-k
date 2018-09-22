using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;


public class rhak : MonoBehaviour {
    private InterstitialAd reklamObjesi;
    public GameObject buto, butt, but;
    public GameObject galpbir, galpiki;
    public GameObject bosgalpbir, bosgalpiki;
    public GameObject our;
    public float hakikk;

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
        hakikk += 1;
        if (hakikk != PlayerPrefs.GetFloat("akı"))
        {
            PlayerPrefs.SetFloat("akı", hakikk);

        }
    }
    public void eksihakcontrol()
    {
        hakikk -= 1;
        if (hakikk != PlayerPrefs.GetFloat("akı"))
        {
            PlayerPrefs.SetFloat("akı", hakikk);
        }
    }
    void Update()
    {
        if (hakikk >= 3)
        {
            hakikk = 2;
        }
        if (PlayerPrefs.GetInt(gameObject.name) == 0)
        {
        }
        if (PlayerPrefs.GetInt(gameObject.name) != 0)
        {
            hakikk = PlayerPrefs.GetFloat("akı");
        }
        if (PlayerPrefs.GetFloat("akı") == 0)
        {
            buto.GetComponent<Button>().interactable = false;
            butt.GetComponent<Button>().interactable = false;
            but.GetComponent<Button>().interactable = false;
            galpbir.SetActive(false);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(true);
            bosgalpiki.SetActive(true);
            our.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("akı") == 1)
        {
            buto.GetComponent<Button>().interactable = true;
            butt.GetComponent<Button>().interactable = true;
            but.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(true);
            our.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("akı") == 2)
        {
            buto.GetComponent<Button>().interactable = true;
            butt.GetComponent<Button>().interactable = true;
            but.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(true);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(false);
            our.SetActive(false);
        }
    }
}
