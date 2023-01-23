using System;
using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        //[SerializeField] private IntVariable _health;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        [SerializeField] private IntReference _healthRef;
        [SerializeField] public IntObservable _healthObservable;
        [SerializeField] private GameManager gmSettings;

        private void Awake()
        {
            //_healthObservable.ApplyChange(gmSettings.playerHealth);
            _healthObservable.SetValue(gmSettings.playerHealth);
            _healthRef.SetValue(gmSettings.playerHealth);
        }

        private void Update()
        {   
            GetComponentInChildren<PolygonCollider2D>().enabled = gmSettings.colActive;   
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid") && !gmSettings.godMode)
            {
                Debug.Log("Hull collided with Asteroid");
                // TODO can we bake this into one call?
                //_healthRef.ApplyChange(-1);
                //_onHealthChangedEvent.Raise(_healthRef);
                _healthObservable.ApplyChange(-1);
            }
        }
    }
}
