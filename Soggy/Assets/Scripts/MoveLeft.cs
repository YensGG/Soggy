using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 3;
    public float offFrameX = 15;
    public float resetPosX = 0;
    public float resetPosY = 0;
    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

        if (transform.position.x < -offFrameX)
        {
            transform.position += new Vector3(resetPosX, resetPosY, 0); // Vector3.right * 30;
            ShowRandomSprite();
            enemy?.Respawn();
        }
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
