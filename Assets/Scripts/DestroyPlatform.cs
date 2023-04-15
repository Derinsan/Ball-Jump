using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
   [SerializeField] private GameObject _pointDestroyPlatform;

   private void Start()
   {
      _pointDestroyPlatform = GameObject.Find("DestroyPlatformPoint");
   }

   private void FixedUpdate()
   {
      if (transform.position.y <= _pointDestroyPlatform.transform.position.y)
      {
         Destroy(gameObject);
      }
   }
}
