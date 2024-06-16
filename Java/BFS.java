import java.util.*;

public class BFS {
    private Map<String, List<String>> graph = new HashMap<>();

    public void addEdge(String source, String destination) {
        graph.putIfAbsent(source, new ArrayList<>());
        graph.putIfAbsent(destination, new ArrayList<>());
        graph.get(source).add(destination);
        graph.get(destination).add(source);
    }

    public void bfs(String start) {
        Set<String> visited = new HashSet<>();
        Queue<String> queue = new LinkedList<>();
        queue.add(start);
        visited.add(start);

        while (!queue.isEmpty()) {
            String node = queue.poll();
            System.out.print(node + " ");
            for (String neighbor : graph.get(node)) {
                if (!visited.contains(neighbor)) {
                    visited.add(neighbor);
                    queue.add(neighbor);
                }
            }
        }
    }

    public static void main(String[] args) {
        BFS bfsExample = new BFS();
        bfsExample.addEdge("A", "B");
        bfsExample.addEdge("A", "C");
        bfsExample.addEdge("B", "D");
        bfsExample.addEdge("B", "E");
        bfsExample.addEdge("C", "F");
        bfsExample.addEdge("E", "F");

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the start node: ");
        String startNode = scanner.nextLine();

        System.out.print("BFS traversal: ");
        bfsExample.bfs(startNode);
        System.out.println();
    }
}
