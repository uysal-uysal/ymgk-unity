using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int chicken = 0;
    private int pig = 0;
    private int cow = 0;

    [SerializeField] private Text cherriesText;
    [SerializeField] private Text chickenText;
    [SerializeField] private Text cowText;
    [SerializeField] private Text pigText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            Destroy(collision.gameObject);
            chicken++;
            chickenText.text = "Chickens : " + chicken;
        }

         if (collision.gameObject.CompareTag("Cow"))
        {
            Destroy(collision.gameObject);
            cow++;
            cowText.text = "Cows : " + cow;
        }

         if (collision.gameObject.CompareTag("Pig"))
        {
            Destroy(collision.gameObject);
            pig++;
            pigText.text = "Pigs : " + pig;
        }
    }

}
