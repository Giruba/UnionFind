using System;
using System.Collections.Generic;
using System.Text;

namespace DetectCycle_UnionFind
{
    class Graph
    {
        int noOfVertices;
        int noEdges;
        Edge[] edges;

        public void SetNoOfVertices(int vertices) {
            noOfVertices = vertices;
        }

        public void SetNoOfEdges(int noEdges) {
            this.noEdges = noEdges;
            edges = new Edge[this.noEdges];
            for (int i = 0; i < noEdges; i++) {
                edges[i] = new Edge();
            }
        }

        public int GetNoOfEdges() {
            return noEdges;
        }

        public void SetEdges(int noEdges) {
            this.edges = new Edge[noEdges];
            for (int i = 0; i < noEdges; i++) {
                edges[i] = new Edge();
            }
        }

        public void SetEdge(int EdgeNo, int source, int destination) {
            edges[EdgeNo].SetSourceVertex(source);
            edges[EdgeNo].SetDestinationVertex(destination);
        }

        public int GetNoOfVertices() {
            return noOfVertices;
        }

        public Edge[] GetEdges() {
            return edges;
        }

        public int GetEdgeSource(int edge) {
            return edges[edge].GetSourceVertex();
        }

        public int GetEdgeDestination(int edge) {
            return edges[edge].GetDestinationVertex();
        }


    }
}
