import java.util.*;

public class DFS {
    private Map<String, List<String>> graph = new HashMap<>();

    public void addEdge(String source, String destination) {
        graph.putIfAbsent(source, new ArrayList<>());
        graph.putIfAbsent(destination, new ArrayList<>());
        graph.get(source).add(destination);
        graph.get(destination).add(source);
    }

    public void dfs(String start) {
        Set<String> visited = new HashSet<>();
        dfsRecursive(start, visited);
    }

    private void dfsRecursive(String node, Set<String> visited) {
        visited.add(node);
        System.out.print(node + " ");
        for (String neighbor : graph.get(node)) {
            if (!visited.contains(neighbor)) {
                dfsRecursive(neighbor, visited);
            }
        }
    }

    public static void main(String[] args) {
        DFS dfsExample = new DFS();
        dfsExample.addEdge("A", "B");
        dfsExample.addEdge("A", "C");
        dfsExample.addEdge("B", "D");
        dfsExample.addEdge("B", "E");
        dfsExample.addEdge("C", "F");
        dfsExample.addEdge("E", "F");

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the start node: ");
        String startNode = scanner.nextLine();

        System.out.print("DFS traversal: ");
        dfsExample.dfs(startNode);
        System.out.println();
    }
}
