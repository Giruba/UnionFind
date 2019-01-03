using System;

namespace DetectCycle_UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Union Find to detect cycle in a graph!");
            Console.WriteLine("--------------------------------------");

            Graph graph = ConstructGraphFromInput();
            try
            {
                if (Utility.isCycle(graph))
                {
                    Console.WriteLine("Graph has a cycle!");
                }
                else {
                    Console.WriteLine("Graph does not have a cycle!");
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static Graph ConstructGraphFromInput() {
            Graph graph = null;
            Console.WriteLine("Enter the number of vertices in the graph");
            try{
                int noVertices = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of edges");
                int noEdges = int.Parse(Console.ReadLine());
                graph = new Graph();
                graph.SetNoOfVertices(noVertices);
                graph.SetNoOfEdges(noEdges);
                for (int i = 0; i < noEdges; i++) {
                    Console.WriteLine("Enter source and destination of edge"+i);
                    string[] srcDest = Console.ReadLine().Split(' ');
                    graph.SetEdge(i, int.Parse(srcDest[0]), int.Parse(srcDest[1]));
                }

            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return graph;
        }
    }
}
