using System;

class Dijkstra
{
    private const int V = 4;

    int MinDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
        {
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }
        }

        return min_index;
    }

    void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex   Distance from Source");
        for (int i = 0; i < V; i++)
            Console.WriteLine(i + " \t\t " + dist[i]);
    }

    public void DijkstraAlgorithm(int[,] graph, int src)
    {
        int[] dist = new int[V];
        bool[] sptSet = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet);

            sptSet[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
            }
        }

        PrintSolution(dist);
    }

    public static void Main()
    {
        int[,] graph = new int[,] {{0, 10, 20, 0},
                                   {10, 0, 5, 15},
                                   {20, 5, 0, 20},
                                   {0, 15, 20, 0}};

        Dijkstra dijkstra = new Dijkstra();
        dijkstra.DijkstraAlgorithm(graph, 0);
    }
}
