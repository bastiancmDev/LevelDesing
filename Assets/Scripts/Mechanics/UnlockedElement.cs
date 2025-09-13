using UnityEngine;
using UnityEngine.Events;

public class UnlockedElement : MonoBehaviour
{
    [SerializeField] KEY_CODE Code;

    public UnityEvent OnElementUnlocked;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<KeyCodeBag>().KeyCodes.Contains(Code))
            {
                gameObject.SetActive(false);
                OnElementUnlocked?.Invoke();
            }
        }
    }
}
