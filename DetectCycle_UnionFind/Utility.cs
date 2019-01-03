using System;
using System.Collections.Generic;
using System.Text;

namespace DetectCycle_UnionFind
{
    static class Utility
    {
        public static bool isCycle(Graph graph) {
            bool result = false;

            int[] parentArray = new int[graph.GetNoOfEdges()];
            for (int i = 0; i < graph.GetNoOfEdges(); i++) {
                parentArray[i] = -1;
            }

            for (int i = 0; i < graph.GetNoOfEdges(); i++) {
                int x = find(parentArray, graph.GetEdgeSource(i));
                int y = find(parentArray, graph.GetEdgeDestination(i));


                if (x == y) {
                    return true;
                }

                Union(parentArray, x, y);                    
            }


            return result;
        }

        private static int find(int[] array, int edge) {
            if (array[edge] == -1) {
                return edge;
            }

            return find(array, array[edge]);
        }

        private static void Union(int[] parentArray, int x, int y) {
            int xset = find(parentArray, x);
            int yset = find(parentArray, y);

            parentArray[xset] = yset;
        }
    }
}
