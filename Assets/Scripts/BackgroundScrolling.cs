using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScrolling : MonoBehaviour
{
    private Vector3 startPosition;
    [SerializeField] private float scrollSpeed;
    [SerializeField] private float tileSizeZ;

    [SerializeField]
    private List<Sprite> sp_list = new List<Sprite>();

    void Start()
    {
        startPosition = transform.position;    
     
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.GetComponent<Image>().sprite = sp_list[Random.Range(0, sp_list.Count)];
            gameObject.transform.GetChild(0).GetComponentInChildren<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
        }

        Scrolling();
    }
        void Scrolling()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.down * newPosition;
    }
}
