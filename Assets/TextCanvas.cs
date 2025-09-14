using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TextCanvas : MonoBehaviour
{
    public static TextCanvas instance;

    [SerializeField] private TextMeshProUGUI Health;

    private int _score;

   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        Health.text = _score.ToString();

    }

   

    public void UpdateScore()
    {
        _score++;
        Health.text = _score.ToString();
    }

}
