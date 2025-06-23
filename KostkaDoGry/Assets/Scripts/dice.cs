using System.Collections;
using UnityEngine;

public class dice : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite[] diceFaces;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Roll());
        }
    }
    IEnumerator Roll()
    {
        int i = Random.Range(1, 7);
        int randomIndex = Random.Range(0, diceFaces.Length);
        yield return new WaitForSeconds(1f);
        Debug.Log($"Wypad³o: {diceFaces[randomIndex]}");
        spriteRenderer.sprite = diceFaces[randomIndex];
    }
}
