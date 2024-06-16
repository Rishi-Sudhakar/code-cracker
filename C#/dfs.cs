using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int n in adj[v])
        {
            if (!visited[n])
                DFSUtil(n, visited);
        }
    }

    public void DFS(int v)
    {
        bool[] visited = new bool[V];

        DFSUtil(v, visited);
    }

    public static void Main()
    {
        Graph g = new Graph(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        Console.Write("DFS traversal starting from vertex 2: ");
        g.DFS(2);
        Console.WriteLine();
    }
}
