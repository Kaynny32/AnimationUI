using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManegrBtnPlay : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField]
    AnimationPopap animationPopap;

    [SerializeField]
    RectTransform _ScaleAnimPopap;
    [SerializeField]
    RectTransform _ScaleAndFadePopap;

    [SerializeField]
    Button _playBtn;

    bool _playing = true;




    private void Start()
    {

    }

    private void Update()
    {
        CheckStateBtn();
       
    }


    public void CheckStateBtn()
    {
        if (_playing)
        {
            _playBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 55;
            _playBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Play";
        }
        else
        {
            _playBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().fontSize = 35;
            _playBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Play Back";
        }
    }

    public void ClickBtn()
    {
        if (_playing == true)
        {
            animationPopap.AnimationScaleShowAndHidePopap(10, 950, 2, 1080, _playing);
            _playing = false;
        }
        else
        {
            animationPopap.AnimationScaleShowAndHidePopap(10, 950, 2, 1080, _playing);
            _playing = true;
        }
    }

    private void OnEnable()
    {
        animationPopap.OnAnimationStart += HandleStart;
        animationPopap.OnAnimationComplete += HandleComplete;
    }

    private void OnDisable()
    {
        animationPopap.OnAnimationStart -= HandleStart;
        animationPopap.OnAnimationComplete -= HandleComplete;
    }

    private void HandleStart()
    {
        Debug.Log("Start animation");
    }

    private void HandleComplete()
    {
        Debug.Log("End of Animation");
    }
}
