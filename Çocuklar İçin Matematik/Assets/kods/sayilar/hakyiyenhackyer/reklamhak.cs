using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class reklamhak : MonoBehaviour {
    private InterstitialAd reklamObjesi;
    public GameObject butons,buttone;
    public GameObject galpbir, galpiki;
    public GameObject bosgalpbir, bosgalpiki;
    public GameObject satis;
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
        if (hak != PlayerPrefs.GetFloat("hakkın3"))
        {
            PlayerPrefs.SetFloat("hakkın3", hak);

        }
    }
    public void eksihakcontrol()
    {
        hak -=1;
        if (hak != PlayerPrefs.GetFloat("hakkın3"))
        {
            PlayerPrefs.SetFloat("hakkın3", hak);

        }
    }
    void Update () {
        if (PlayerPrefs.GetInt(gameObject.name) == 0)
        {
        }
        if (PlayerPrefs.GetInt(gameObject.name) != 0)
        {
            hak = PlayerPrefs.GetFloat("hakkın3");
        }
        if (PlayerPrefs.GetFloat("hakkın3") == 0)
        {

            butons.GetComponent<Button>().interactable = false;
            buttone.GetComponent<Button>().interactable = false;
            galpbir.SetActive(false);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(true);
            bosgalpiki.SetActive(true);
            satis.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("hakkın3") == 1)
        {
            butons.GetComponent<Button>().interactable = true;
            buttone.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(false);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(true);
            satis.SetActive(false);
        }
        if (PlayerPrefs.GetFloat("hakkın3") == 2)
        {
            butons.GetComponent<Button>().interactable = true;
            buttone.GetComponent<Button>().interactable = true;
            galpbir.SetActive(true);
            galpiki.SetActive(true);
            bosgalpbir.SetActive(false);
            bosgalpiki.SetActive(false);
            satis.SetActive(false);
        }
        if (hak >= 3)
        {
            hak = 2;
        }
    }
}
