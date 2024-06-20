using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ChunkRenderer : MonoBehaviour
{
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    
    private readonly List<Vector3> _vertices = new List<Vector3>();
    private readonly List<int> _triangles = new List<int>();
    

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<MeshRenderer>();
        
        Mesh mesh = new Mesh();
        
        _vertices.Add(new Vector3(0,0,0));
        _vertices.Add(new Vector3(0,1,0));
        _vertices.Add(new Vector3(0,0,1));
        _vertices.Add(new Vector3(0,1,1));
        
        _triangles.Add(0);
        _triangles.Add(1);
        _triangles.Add(2);
        
        _triangles.Add(1);
        _triangles.Add(3);
        _triangles.Add(2);
        
        mesh.vertices = _vertices.ToArray();
        mesh.triangles = _triangles.ToArray();
        
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();

        meshFilter.mesh = mesh;
    }

    private void RenderBlock(int x, int y, int z, BlockType type)
    {
        
    }
}
