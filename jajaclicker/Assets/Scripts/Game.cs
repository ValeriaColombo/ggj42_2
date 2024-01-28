using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public AudioClip[] jas;
    public Sprite[] big;
    public Sprite[] small;
    public Image buttonBig;
    public Image buttonSmall;
    public Animator anim;
    public AudioSource audioSouce;
    public TMP_Text timesTxt;

    private int currentColor;
    private int times = 0;

    void Start()
    {
        ChangeColor();
        timesTxt.text = "You made me laugh " + times.ToString() + " times";
    }

    private void ChangeColor()
    {
        currentColor = Random.Range(0, big.Length);

        buttonBig.sprite = big[currentColor];
        buttonSmall.sprite = small[currentColor];
    }

    public void OnClick() 
    {
        anim.Play("click");
        ChangeColor();

        times++;
        timesTxt.text = "You made me laugh " + times.ToString() + " times";

        audioSouce.clip = jas[Random.Range(0,jas.Length)];
        audioSouce.loop = false;
        audioSouce.Play();
    }

}
