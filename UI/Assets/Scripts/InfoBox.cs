using UnityEngine;
using TMPro;
public class InfoBox : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;
    void Start()
    {
        infoText.text = "Witaj Œwiecie";
    }

    void Update()
    {
        Debug.Log(Time.time);
    }

    public void CloseInfoBox()
    {
        gameObject.SetActive(false);
    }
}
