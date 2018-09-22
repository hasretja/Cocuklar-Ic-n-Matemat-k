using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kolaykodds : MonoBehaviour {
    public GameObject[] dogru1;
    public GameObject[] yanlis1;
    public GameObject[] dogru2;
    public GameObject[] yanlis2;
    public GameObject[] dogru3;
    public GameObject[] yanlis3;
    public GameObject[] dogru4;
    public GameObject[] yanlis4;
    public GameObject[] dogru5;
    public GameObject[] yanlis5;
    public GameObject[] panellll;
    public Text puan;
    public Text dogrular;
    public Text yanlislar;
    public Text rekor;
    public float puanı;
    public float dogrusu;
    public float yanlisi;
    void Start () {
        dogru1[0].SetActive(false);
        dogru1[1].SetActive(false);
        dogru1[2].SetActive(false);
        dogru1[3].SetActive(false);
        dogru1[4].SetActive(false);

        yanlis1[0].SetActive(false);
        yanlis1[1].SetActive(false);
        yanlis1[2].SetActive(false);
        yanlis1[3].SetActive(false);
        yanlis1[4].SetActive(false);

        dogru2[0].SetActive(false);
        dogru2[1].SetActive(false);
        dogru2[2].SetActive(false);
        dogru2[3].SetActive(false);

        yanlis2[0].SetActive(false);
        yanlis2[1].SetActive(false);
        yanlis2[2].SetActive(false);
        yanlis2[3].SetActive(false);

        dogru3[0].SetActive(false);
        dogru3[1].SetActive(false);
        dogru3[2].SetActive(false);

        yanlis3[0].SetActive(false);
        yanlis3[1].SetActive(false);
        yanlis3[2].SetActive(false);

        dogru4[0].SetActive(false);
        dogru4[1].SetActive(false);

        yanlis4[0].SetActive(false);
        yanlis4[1].SetActive(false);

        dogru5[0].SetActive(false);

        yanlis5[0].SetActive(false);
        puanı = 0;
        dogrusu = 0;
        yanlisi = 0;
    }
    public void dogrubutton1()
    {
        dogru1[0].SetActive(true);
        dogru1[1].SetActive(true);
        dogru1[2].SetActive(true);
        dogru1[3].SetActive(true);
        dogru1[4].SetActive(true);
        yanlis1[0].SetActive(false);
        yanlis1[1].SetActive(false);
        yanlis1[2].SetActive(false);
        yanlis1[3].SetActive(false);
        yanlis1[4].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(true);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        dogrusu = dogrusu + 1;
        puanı = puanı + 10;
    }
    public void yanlisbutton1()
    {
        yanlis1[0].SetActive(true);
        yanlis1[1].SetActive(true);
        yanlis1[2].SetActive(true);
        yanlis1[3].SetActive(true);
        yanlis1[4].SetActive(true);
        dogru1[0].SetActive(false);
        dogru1[1].SetActive(false);
        dogru1[2].SetActive(false);
        dogru1[3].SetActive(false);
        dogru1[4].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(true);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        yanlisi = yanlisi + 1;
    }
    public void dogrubutton2()
    {
        dogru2[0].SetActive(true);
        dogru2[1].SetActive(true);
        dogru2[2].SetActive(true);
        dogru2[3].SetActive(true);
        yanlis2[0].SetActive(false);
        yanlis2[1].SetActive(false);
        yanlis2[2].SetActive(false);
        yanlis2[3].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(true);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        dogrusu = dogrusu + 1;
        puanı = puanı + 10;
    }
    public void yanlisbutton2()
    {
        yanlis2[0].SetActive(true);
        yanlis2[1].SetActive(true);
        yanlis2[2].SetActive(true);
        yanlis2[3].SetActive(true);
        dogru2[0].SetActive(false);
        dogru2[1].SetActive(false);
        dogru2[2].SetActive(false);
        dogru2[3].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(true);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        yanlisi = yanlisi + 1;
    }
    public void dogrubutton3()
    {
        dogru3[0].SetActive(true);
        dogru3[1].SetActive(true);
        dogru3[2].SetActive(true);
        yanlis3[0].SetActive(false);
        yanlis3[1].SetActive(false);
        yanlis3[2].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(true);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        dogrusu = dogrusu + 1;
        puanı = puanı + 10;
    }
    public void yanlisbutton3()
    {
        yanlis3[0].SetActive(true);
        yanlis3[1].SetActive(true);
        yanlis3[2].SetActive(true);
        dogru3[0].SetActive(false);
        dogru3[1].SetActive(false);
        dogru3[2].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(true);
        panellll[4].SetActive(false);
        panellll[5].SetActive(false);
        yanlisi = yanlisi + 1;
    }
    public void dogrubutton4()
    {
        dogru4[0].SetActive(true);
        dogru4[1].SetActive(true);
        yanlis4[0].SetActive(false);
        yanlis4[1].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(true);
        panellll[5].SetActive(false);
        dogrusu = dogrusu + 1;
        puanı = puanı + 10;
    }
    public void yanlisbutton4()
    {
        yanlis4[0].SetActive(true);
        yanlis4[1].SetActive(true);
        dogru4[0].SetActive(false);
        dogru4[1].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(true);
        panellll[5].SetActive(false);
        yanlisi = yanlisi + 1;
    }
    public void dogrubutton5()
    {
        dogru5[0].SetActive(true);
        yanlis5[0].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(true);
        dogrusu = dogrusu + 1;
        puanı = puanı + 10;
    }
    public void yanlisbutton5()
    {
        yanlis5[0].SetActive(true);
        dogru5[0].SetActive(false);
        panellll[0].SetActive(false);
        panellll[1].SetActive(false);
        panellll[2].SetActive(false);
        panellll[3].SetActive(false);
        panellll[4].SetActive(false);
        panellll[5].SetActive(true);
        yanlisi = yanlisi + 1;
    }
    void Update () {
        if (puanı> PlayerPrefs.GetFloat("REKOR3"))
        {

            PlayerPrefs.SetFloat("REKOR3", puanı);

        }
        rekor.text = PlayerPrefs.GetFloat("REKOR3").ToString();
        dogrular.text = dogrusu.ToString();
        puan.text = puanı.ToString();
        yanlislar.text = yanlisi.ToString();
    }
}
