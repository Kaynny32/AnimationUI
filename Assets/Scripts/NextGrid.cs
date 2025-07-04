using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextGrid : MonoBehaviour
{
    [Header("Grid")]
    [SerializeField]
    List<DataGrid> _listGridCon = new List<DataGrid>();

    [Space]
    [Header("Input")]
    [SerializeField]
    KeyCode _keyCodeNextGrid;


    [Space]
    [Header("Ease")]
    [SerializeField]
    Ease ease;

    int idActiveGrid = 1;
    int _countGrid = 0;


    private void Start()
    {
        _countGrid = _listGridCon.Count;
    }

    private void Update()
    {

        if (idActiveGrid == _countGrid)
        {
            idActiveGrid = 0;
        }
    }

    public void NextGridBtn()
    {
        idActiveGrid++;
        MoveGridLefatOrRight(idActiveGrid);
    }

    public void MoveGridLefatOrRight(int idActive)
    {
        foreach (DataGrid dataGrid in _listGridCon)
        {
            dataGrid.rectTransform.DOKill();
            dataGrid.rectTransform.DOAnchorPosX(0, 0.5f).SetEase(ease);
            dataGrid.canvasGroup.interactable = false;
            dataGrid.canvasGroup.blocksRaycasts = false;
            dataGrid.canvasGroup.DOFade(0, 0.25f);
            if (idActive == dataGrid.idGrid)
            {
                dataGrid.canvasGroup.DOFade(1, 0.5f).SetEase(ease);
                dataGrid.rectTransform.DOAnchorPosX(1700, 0.5f).SetEase(ease);
                dataGrid.canvasGroup.interactable = true;
                dataGrid.canvasGroup.blocksRaycasts = true;
            }

        }
    }
}

[Serializable]
public class DataGrid
{
    public int idGrid;
    public RectTransform rectTransform;
    public CanvasGroup canvasGroup;
}
