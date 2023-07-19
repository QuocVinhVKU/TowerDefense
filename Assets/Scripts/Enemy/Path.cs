using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TD_CGO
{
    public class Path : MonoBehaviour
    {
        [SerializeField] List<Transform> path;

        public List<Vector3> GetPosPath()
        { 
            List<Vector3> poinPos = new List<Vector3>();
            foreach (var pos in path)
            {
                poinPos.Add(pos.position);
            }
            return poinPos;
        }
        private void OnDrawGizmos()
        {
            //GetPosPath();
            for (int i = 0; i < path.Count - 1; i++)
            {
                Gizmos.DrawLine(path[i].position, path[i + 1].position);
            }
        }
    }
}