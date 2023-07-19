using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TD_CGO
{
    public class EnemyMovement : MonoBehaviour
    {
        [HideInInspector]
        public float speed;

        [SerializeField] Path path;

        private Vector3 startPos;
        private Vector3 endPos;
        private int currentIndex = 0;
        private List<Vector3> poinPos;
        private bool isReached;

        private void Start()
        {
            poinPos = path.GetPosPath();
            transform.position = poinPos[0];
            startPos = poinPos[currentIndex];
            endPos = poinPos[currentIndex + 1];

        }
        private void Update()
        {
            if (!isReached)
            {
                Movement();
            }
        }
        private void Movement()
        {
            Vector3 direction = endPos - startPos;
            direction.Normalize();

            transform.position += direction * speed * Time.deltaTime;
            if (Vector3.Distance(transform.position, endPos) <= 0.05f)
            {
                currentIndex += 1;
                if (currentIndex == poinPos.Count - 1)
                {
                    isReached = true;
                    return;
                }
                startPos = poinPos[currentIndex];
                endPos = poinPos[currentIndex + 1];
            }
        }
        
    }
}

