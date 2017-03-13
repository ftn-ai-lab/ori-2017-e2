using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretrageOsnovno
{
    class Graph
    {
        public Dictionary<Node, List<Node>> graph;

        public Graph(string[] lines)
        {
            graph = new Dictionary<Node, List<Node>>();
            formGraph(lines);
        }

        //TODO 2 : Implementirati metodu
        private void formGraph(string[] lines)
        {

        }

        //TODO 3: Implementirati metodu koja prolazi kroz graph, cita njegov sadrzaj i upisuje u datoteku
        public void printGraph()
        {

        }



    }
}
