using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FlowerCoinCollected : MonoBehaviour
{
    //[SerializeField] private Slider flowerSlider;

    public float _flowerCount=0f;
    public float _coinCount=0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flower"))
        {
            Destroy(collision.gameObject);
            _flowerCount++;
            //flowerSlider.value = _flowerCount;
            UIManager.Instance.UpdateFlowerValue(_flowerCount);

        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            _coinCount++;
            UIManager.Instance.UpdateCoinValue(_coinCount);
        }
        if (collision.gameObject.CompareTag("Thorn"))
        {
            _flowerCount--;
            UIManager.Instance.UpdateFlowerIncrement(_flowerCount);
        }
    }

}
