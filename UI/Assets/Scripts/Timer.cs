using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    void Start()
    {
        
    }

    void Update()
    {
        int time = Mathf.FloorToInt(Time.time); // Przekszta³ca liczbê float na pe³n¹ liczbê ca³kowit¹ poprzez zaokr¹glenie w dó³.
        timerText.text = $"{time} s";
    }
}
