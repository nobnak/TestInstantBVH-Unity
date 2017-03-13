using UnityEngine;
using System.Collections;
using Recon.BoundingVolumes.Behaviour;
using Recon.BoundingVolumes;

public class TestIntersection : MonoBehaviour {
    public Color color;
    public ConvexBuilder[] convexes;

	void OnDrawGizmos() {
        IConvexPolyhedron ac, bc;

        Gizmos.color = color;

        foreach (var a in convexes) {
            if (a == null || (ac = a.GetConvexPolyhedron()) == null)
                continue;
            
            foreach (var b in convexes) {
                if (b == null || (bc = b.GetConvexPolyhedron()) == null)
                    continue;

                if (ac.Intersect (bc))
                    Gizmos.DrawLine (a.transform.position, b.transform.position);

            }
        }
	}
}
