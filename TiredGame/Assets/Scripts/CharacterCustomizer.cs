using UnityEngine;
using UnityEngine.UI;
public class CharacterCustomizer : MonoBehaviour
{
    public int charImageInt;
    public SpriteRenderer charImage;
    public Sprite[] charSprites;
    private Material col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        charImage = GetComponent<SpriteRenderer>();
        charImageInt = Random.Range(0, 2);
        charImage.sprite = charSprites[charImageInt];
        charImage.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0.5f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
