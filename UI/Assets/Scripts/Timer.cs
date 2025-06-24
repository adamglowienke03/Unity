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
        int time = Mathf.FloorToInt(Time.time); // Przekszta�ca liczb� float na pe�n� liczb� ca�kowit� poprzez zaokr�glenie w d�.
        timerText.text = $"{time} s";
    }
}
