using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyTextEffects;
using TMPro;

public class TestAnimationText : MonoBehaviour
{
    [SerializeField]
    TextEffect textEffects;
    [SerializeField]
    TextEffect textEffects2;
    [SerializeField]
    TextEffect textEffects3;
    [SerializeField]
    TextEffect textEffects4;
    [SerializeField]
    TextEffect textEffects5;
    [SerializeField]
    TextEffect textRotate;
    [SerializeField]
    TextEffect textRotateAndScale;
    [SerializeField]
    TextEffect textRotateScaleAndFadeIn;

    [SerializeField]
    KeyCode _keyCodeStartAnimLineOne;
    [SerializeField]
    KeyCode _keyCodeStartAnimLineTwo;




    private void Update()
    {
        if (Input.GetKeyDown(_keyCodeStartAnimLineOne))
            StartCoroutine(StartAnimLineOne());


        if (Input.GetKeyDown(_keyCodeStartAnimLineTwo))
            StartCoroutine(StartAnimLineTwo());


        if (Input.GetKeyDown(KeyCode.R))
            testAnimStop();

    }

    IEnumerator StartAnimLineOne()
    {
        ResetAnimation();
        TestAnimStart(textEffects);
        TestAnimStart(textEffects3);
        TestAnimStart(textEffects4);
        TestAnimStart(textEffects5);
        yield return new WaitForSeconds(5f);
        StartCoroutine(StartAnimLineOne());
    }

    IEnumerator StartAnimLineTwo()
    {
        TestAnimStart(textRotate);
        TestAnimStart(textRotateAndScale);
        TestAnimStart(textRotateScaleAndFadeIn);
        yield return new WaitForSeconds(5f);
        StartCoroutine(StartAnimLineTwo());
    }

    public void TestAnimStart(TextEffect textEffect)
    {
        textEffect.StartManualEffects();

    }

    public void testAnimStop()
    {
        textEffects.StopManualEffects();
    }

    public void ShowText(TextEffect textEffect)
    {
        textEffect.GetComponent<TextMeshProUGUI>().alpha = 1;
    }

    public void HideText(TextEffect textEffect)
    {
        textEffect.GetComponent<TextMeshProUGUI>().alpha = 0;
    }

    public void ResetAnimation()
    {
        HideText(textEffects);
        HideText(textEffects2);
    }

    public void TestDebug(string str)
    {
        Debug.Log(str);
    }
}
