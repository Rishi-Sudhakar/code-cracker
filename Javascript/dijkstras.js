class PriorityQueue {
    constructor() {
        this.values = [];
    }

    enqueue(val, priority) {
        this.values.push({ val, priority });
        this.sort();
    }

    dequeue() {
        return this.values.shift();
    }

    sort() {
        this.values.sort((a, b) => a.priority - b.priority);
    }

    isEmpty() {
        return this.values.length === 0;
    }
}

class Graph {
    constructor() {
        this.vertices = [];
        this.edges = [];
    }

    addVertex(vertex) {
        this.vertices.push(vertex);
        this.edges[vertex] = [];
    }

    addEdge(vertex1, vertex2, weight) {
        this.edges[vertex1].push({ node: vertex2, weight: weight });
        this.edges[vertex2].push({ node: vertex1, weight: weight });
    }

    dijkstra(start) {
        let distances = {};
        let priorityQueue = new PriorityQueue();
        let previous = {};
        let path = [];

        for (let vertex of this.vertices) {
            if (vertex === start) {
                distances[vertex] = 0;
                priorityQueue.enqueue(vertex, 0);
            } else {
                distances[vertex] = Infinity;
                priorityQueue.enqueue(vertex, Infinity);
            }
            previous[vertex] = null;
        }

        while (!priorityQueue.isEmpty()) {
            let smallest = priorityQueue.dequeue().val;

            if (smallest === end) {
                while (previous[smallest]) {
                    path.push(smallest);
                    smallest = previous[smallest];
                }
                break;
            }

            if (smallest || distances[smallest] !== Infinity) {
                for (let neighbor of this.edges[smallest]) {
                    let nextNode = neighbor.node;
                    let candidate = distances[smallest] + neighbor.weight;

                    if (candidate < distances[nextNode]) {
                        distances[nextNode] = candidate;
                        previous[nextNode] = smallest;
                        priorityQueue.enqueue(nextNode, candidate);
                    }
                }
            }
        }

        return path.concat(smallest).reverse();
    }
}

let graph = new Graph();

graph.addVertex('A');
graph.addVertex('B');
graph.addVertex('C');
graph.addVertex('D');
graph.addVertex('E');
graph.addVertex('F');

graph.addEdge('A', 'B', 4);
graph.addEdge('A', 'C', 2);
graph.addEdge('B', 'E', 3);
graph.addEdge('C', 'D', 2);
graph.addEdge('C', 'F', 4);
graph.addEdge('D', 'E', 3);
graph.addEdge('D', 'F', 1);
graph.addEdge('E', 'F', 1);

let start = 'A';
let end = 'E';
let shortestPath = graph.dijkstra(start, end);

console.log(`Shortest path from ${start} to ${end}: ${shortestPath.join(' -> ')}`);
