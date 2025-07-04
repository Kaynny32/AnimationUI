using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyTextEffects;


public class DemoAnimText : MonoBehaviour
{
    //[Header("Input")]
    //[SerializeField]
    //KeyCode _keuStartAnim;

    [Space]
    [Header("Effects Grid One")]
    [SerializeField]
    TextEffect _effectsFadeInAndScaleAnim;
    [SerializeField]
    TextEffect _effectsRotateScaleAnimTxt;
    [SerializeField]
    TextEffect _effectsRotateFadeInTxt;
    [SerializeField]
    TextEffect _effectsFadeMoveRotateScaleTxt;
    [SerializeField]
    TextEffect _effectsFadeScaleRotateAnimTxt;

    [Space]
    [Header("Effects Grid Two")]
    [SerializeField]
    TextEffect _effectsTypewriterAnim;
    [SerializeField]
    TextEffect _effectsBetweenAnimTxt;
    [SerializeField]
    TextEffect _effectsBetweenTwoAlphaTxt;
    [SerializeField]
    TextEffect _effectsBetweenTwoAlphaZeroTxt;
    //[SerializeField]
    //TextEffect _effectsRotateFadeInTxt;
    //[SerializeField]
    //TextEffect _effectsFadeMoveRotateScaleTxt;

    private void Start()
    {
        StartCoroutine(StartAnimTextLoop());
    }

    private void Update()
    {
        //if (Input.GetKeyDown(_keuStartAnim))
           
    }

    IEnumerator StartAnimTextLoop()
    {
        StartAnimText(_effectsFadeInAndScaleAnim);
        StartAnimText(_effectsRotateScaleAnimTxt);
        StartAnimText(_effectsRotateFadeInTxt);
        StartAnimText(_effectsFadeMoveRotateScaleTxt);
        StartAnimText(_effectsTypewriterAnim);
        StartAnimText(_effectsBetweenAnimTxt);
        StartAnimText(_effectsFadeScaleRotateAnimTxt);
        StartAnimText(_effectsBetweenTwoAlphaTxt);
        StartAnimText(_effectsBetweenTwoAlphaZeroTxt);
        yield return new WaitForSeconds(5f);
        StartCoroutine(StartAnimTextLoop());
    }

    void StartAnimText(TextEffect textEffect)
    {
        textEffect.StartManualEffects();
    }
}
