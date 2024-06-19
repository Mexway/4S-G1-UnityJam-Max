using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    private float currentTime;
    public float startingTime = 42f;

    [SerializeField] private Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
        UpdateCountdownText();
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime < 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        UpdateCountdownText();
    }

    private void UpdateCountdownText()
    {
        countdownText.text = Mathf.Ceil(currentTime).ToString();
        countdownText.color = Color.white;
    }
}
