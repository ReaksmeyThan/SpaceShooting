using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BacgroundScrolling : MonoBehaviour
{
   
    private Image img_background = null;
    [SerializeField]
    private float speed = 0.5f;

    [SerializeField]
    private List<Sprite> sprites = new List<Sprite>();

    void Start()
    {
        img_background = gameObject.GetComponent<Image>();
    }
   
    void Update()
    {
        UpdateBackground();
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ChangBackground();
        }
    }

    private void UpdateBackground()
    {
        img_background.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }

    private void ChangBackground()
    {
        img_background.sprite = sprites[Random.Range(0, sprites.Count)];
    }
}
