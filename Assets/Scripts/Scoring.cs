using UnityEngine;

namespace DefaultNamespace
{
    public static class Scoring
    {
        private static float _initX;
        private static float _maxX;
        private const float MULTIPLIER = 1.0f; 
        
        public static void Start(float x)
        {
            _initX = 0;
            _maxX = 0;
        }

        public static void SetDistance(float x)
        {
            _maxX = Mathf.Max(x, _maxX);
        }

        public static int GetPoints()
        {
            var distance = Mathf.Max(0, _maxX - _initX);
            return (int) (distance * MULTIPLIER);
        }
    }
}