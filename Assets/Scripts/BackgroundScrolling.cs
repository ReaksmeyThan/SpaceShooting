using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScrolling : MonoBehaviour
{

    [SerializeField]
    private List<Sprite> sp_list = new List<Sprite>();
    public Material material_;
    public float speed = 0.1f;

    private void Start()
    {
        material_ = gameObject.GetComponent<Image>().material;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.GetComponent<Image>().sprite = sp_list[Random.Range(0, sp_list.Count)];
        
        }
        material_.mainTextureOffset += new Vector2(0,speed*Time.deltaTime);
    }
}
