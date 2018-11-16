using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour
{
    public Sprite[] gifsprites;
    public float speed;
    private SpriteRenderer spriterenderer;
    // Use this for initialization
    void Start()
    {
        // SceneManager.LoadScene("main");
        spriterenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * speed) % gifsprites.Length;
        spriterenderer.sprite = gifsprites[index];
    }
}
