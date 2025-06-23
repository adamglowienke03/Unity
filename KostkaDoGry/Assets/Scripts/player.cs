using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] Color32[] colors;

    void Start()
    {
        int randNum = Random.Range(0, colors.Length);
        GetComponent<SpriteRenderer>().color = colors[randNum];
    }

    void Update()
    {
        
    }
}
