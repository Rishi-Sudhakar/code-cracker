import java.util.*;

public class Dijkstra {
    public static class Node implements Comparable<Node> {
        public String name;
        public int distance;

        public Node(String name, int distance) {
            this.name = name;
            this.distance = distance;
        }

        @Override
        public int compareTo(Node other) {
            return Integer.compare(this.distance, other.distance);
        }
    }

    public static Map<String, Integer> dijkstra(Map<String, Map<String, Integer>> graph, String start) {
        Map<String, Integer> distances = new HashMap<>();
        PriorityQueue<Node> pq = new PriorityQueue<>();
        pq.add(new Node(start, 0));
        distances.put(start, 0);

        while (!pq.isEmpty()) {
            Node current = pq.poll();
            String currentNode = current.name;
            int currentDistance = current.distance;

            if (currentDistance > distances.getOrDefault(currentNode, Integer.MAX_VALUE)) {
                continue;
            }

            for (Map.Entry<String, Integer> neighbor : graph.get(currentNode).entrySet()) {
                String neighborNode = neighbor.getKey();
                int newDist = currentDistance + neighbor.getValue();
                if (newDist < distances.getOrDefault(neighborNode, Integer.MAX_VALUE)) {
                    distances.put(neighborNode, newDist);
                    pq.add(new Node(neighborNode, newDist));
                }
            }
        }
        return distances;
    }

    public static void main(String[] args) {
        Map<String, Map<String, Integer>> graph = new HashMap<>();
        graph.put("A", Map.of("B", 1, "C", 4));
        graph.put("B", Map.of("A", 1, "C", 2, "D", 5));
        graph.put("C", Map.of("A", 4, "B", 2, "D", 1));
        graph.put("D", Map.of("B", 5, "C", 1));

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the start node: ");
        String startNode = scanner.nextLine();

        Map<String, Integer> distances = dijkstra(graph, startNode);
        System.out.println("Shortest distances from " + startNode + ": " + distances);
    }
}
