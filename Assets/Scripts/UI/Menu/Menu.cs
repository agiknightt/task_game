using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using IJunior.TypedScenes;

public class Menu : MonoBehaviour
{
    [SerializeField] private Image _imagePanel;
    [SerializeField] private GameObject _panel;
    public void StartGame()
    {
        GameScene.Load();
    }
    public void OpenAuthors()
    {
        ChangedAuthors(true, 1);
    }
    public void CloseAuthors()
    {
        ChangedAuthors(false, 0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void ChangedAuthors(bool isOpen, int hide)
    {
        _imagePanel.DOFade(hide, 1);
        _imagePanel.raycastTarget = isOpen;
        _panel.SetActive(isOpen);
    }
}
