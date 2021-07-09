using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] Text scoreValueText;
    [SerializeField] float coinRotateSpeed;


    private void Update()
    {
        transform.Rotate(new Vector3(0f, coinRotateSpeed, 0f));
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int scoreValue = int.Parse(scoreValueText.text);
            scoreValue += 50;
            scoreValueText.text = scoreValue.ToString();
            Destroy(gameObject);
        }
    }




}

