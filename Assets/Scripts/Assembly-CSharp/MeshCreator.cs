using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshCreator : MonoBehaviour
{
	public virtual void CreateMesh()
	{
	}
}
