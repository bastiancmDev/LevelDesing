using UnityEngine;
using UnityEngine.Events;

public class KeyElement : MonoBehaviour
{
    [SerializeField] KEY_CODE Code;

    public UnityEvent OnRecoletKey;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<KeyCodeBag>().AddKey(Code);
            OnRecoletKey?.Invoke();
        }
    }
}
