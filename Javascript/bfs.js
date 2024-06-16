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

    bfs(start) {
        let visited = {};
        let queue = [];

        visited[start] = true;
        queue.push(start);

        while (queue.length > 0) {
            let v = queue.shift();
            console.log(v);

            let neighbors = this.adjList.get(v);
            for (let neighbor of neighbors) {
                if (!visited[neighbor]) {
                    visited[neighbor] = true;
                    queue.push(neighbor);
                }
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

console.log('BFS traversal starting from vertex A:');
g.bfs('A');
