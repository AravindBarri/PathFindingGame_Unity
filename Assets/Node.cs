using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NodeType
{
    Open = 1,
    Blocked = 0
}
public class Node
{
    public NodeType nodeType = NodeType.Open;
    public int xIndex = -1;
    public int yIndex = -1;
    public Vector3 position;
    public List<Node> neighbors = new List<Node>();
    public Node previous = null;

    public Node(int xind,int yind, NodeType nodeType)
    {
        xIndex = xind;
        yIndex = yind;
        this.nodeType = nodeType;
    }
    public void reset()
    {
        previous = null;
    }
}
