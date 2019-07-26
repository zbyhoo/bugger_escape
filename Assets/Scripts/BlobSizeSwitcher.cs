using UnityEngine;

namespace DefaultNamespace
{
    public class BlobSizeSwitcher : MonoBehaviour
    {
        [SerializeField] private JellySprite[] _blobs;

        private int _index = 0;
        private float _scale = 1;
        private JellySprite _next;
        private JellySprite _current;

        void Update()
        {
            if (_next != null)
            {
                UpdateBlob();
                _next = null;
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                ChangeBlob(1);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                ChangeBlob(-1);
            }
        }

        private void ChangeBlob(int step)
        {
            int nextIndex = _index + step;
            if (nextIndex < 0 || nextIndex >= _blobs.Length)
            {
                return;
            }
            
            _current = _blobs[_index];
            _next = _blobs[_index + step];
            _index = nextIndex;
            
            _next.transform.position = _current.transform.position;
            _current.gameObject.SetActive(false);
            _next.gameObject.SetActive(true);
        }

        private void CopySettings(JellySprite.ReferencePoint from, JellySprite.ReferencePoint to)
        {
            to.transform.position = from.transform.position;
            to.transform.rotation = from.transform.rotation;
            to.Body2D.velocity = from.Body2D.velocity;
            to.Body2D.angularVelocity = from.Body2D.angularVelocity;
            to.Body2D.gravityScale = from.Body2D.gravityScale;
            to.Body2D.position = from.Body2D.position;
            to.Body2D.rotation = from.Body2D.rotation;
        }

        private void UpdateBlob()
        {
            _next.transform.position = _current.transform.position; 
            
            for (int i = 0; i < _current.ReferencePoints.Count; i++)
            {
                JellySprite.ReferencePoint from = _current.ReferencePoints[i];
                JellySprite.ReferencePoint to = _next.ReferencePoints[i];

                CopySettings(from, to);
            }
            
            CopySettings(_current.CentralPoint, _next.CentralPoint);
        }
    }
}