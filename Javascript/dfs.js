class Graph {
    constructor() {
        this.adjList = new Map();
    }

    addVertex(v) {
        this.adjList.set(v, []);
    }

    addEdge(v, w) {
        this.adjList.get(v).push(w);
    }

    dfs(start) {
        let visited = {};
        this._dfsHelper(start, visited);
    }

    _dfsHelper(v, visited) {
        visited[v] = true;
        console.log(v);

        let neighbors = this.adjList.get(v);
        for (let neighbor of neighbors) {
            if (!visited[neighbor]) {
                this._dfsHelper(neighbor, visited);
            }
        }
    }
}

let g = new Graph();
let vertices = ['A', 'B', 'C', 'D', 'E', 'F'];

for (let v of vertices) {
    g.addVertex(v);
}

g.addEdge('A', 'B');
g.addEdge('A', 'C');
g.addEdge('B', 'D');
g.addEdge('B', 'E');
g.addEdge('C', 'F');

console.log('DFS traversal starting from vertex A:');
g.dfs('A');
