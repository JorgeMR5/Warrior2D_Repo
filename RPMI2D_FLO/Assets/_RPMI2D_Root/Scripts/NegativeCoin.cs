using UnityEngine;

public class NegativeCoin : MonoBehaviour
{
    [SerializeField] int minusHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Se accede a la vida en el GameManager, se resta y luego se apaga la moneda
            GameManager.Instance.playerHealth -= minusHealth;
            AudioManager.Instance.PlaySFX(2);
            gameObject.SetActive(false);
        }
    }
}
