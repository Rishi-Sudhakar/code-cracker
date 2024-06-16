#include <iostream>
#include <list>

class Graph {
    int V;
    std::list<int>* adj;

    void DFSUtil(int v, bool visited[]) {
        visited[v] = true;
        std::cout << v << " ";

        for (auto it = adj[v].begin(); it != adj[v].end(); ++it)
            if (!visited[*it])
                DFSUtil(*it, visited);
    }

public:
    Graph(int v) {
        V = v;
        adj = new std::list<int>[V];
    }

    void addEdge(int v, int w) {
        adj[v].push_back(w);
    }

    void DFS(int v) {
        bool* visited = new bool[V];
        for (int i = 0; i < V; i++)
            visited[i] = false;

        DFSUtil(v, visited);
    }
};

int main() {
    Graph g(4);
    g.addEdge(0, 1);
    g.addEdge(0, 2);
    g.addEdge(1, 2);
    g.addEdge(2, 0);
    g.addEdge(2, 3);
    g.addEdge(3, 3);

    std::cout << "DFS traversal starting from vertex 2: ";
    g.DFS(2);
    std::cout << "\n";

    return 0;
}
