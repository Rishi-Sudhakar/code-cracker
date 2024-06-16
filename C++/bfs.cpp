#include <iostream>
#include <list>
#include <queue>

class Graph {
    int V;
    std::list<int>* adj;

public:
    Graph(int v) {
        V = v;
        adj = new std::list<int>[V];
    }

    void addEdge(int v, int w) {
        adj[v].push_back(w);
    }

    void BFS(int s) {
        bool* visited = new bool[V];
        for (int i = 0; i < V; i++)
            visited[i] = false;

        std::queue<int> queue;
        visited[s] = true;
        queue.push(s);

        while (!queue.empty()) {
            s = queue.front();
            std::cout << s << " ";
            queue.pop();

            for (auto it = adj[s].begin(); it != adj[s].end(); ++it) {
                if (!visited[*it]) {
                    visited[*it] = true;
                    queue.push(*it);
                }
            }
        }
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

    std::cout << "BFS traversal starting from vertex 2: ";
    g.BFS(2);
    std::cout << "\n";

    return 0;
}
