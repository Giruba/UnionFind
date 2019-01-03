using System;
using System.Collections.Generic;
using System.Text;

namespace DetectCycle_UnionFind
{
    class Edge
    {
        int sourceVertex;
        int destinationVertex;

        public int GetSourceVertex() {
            return sourceVertex;
        }

        public int GetDestinationVertex() {
            return destinationVertex;
        }

        public void SetSourceVertex(int vertex) {
            sourceVertex = vertex;
        }

        public void SetDestinationVertex(int vertex) {
            destinationVertex = vertex;
        }

    }
}
