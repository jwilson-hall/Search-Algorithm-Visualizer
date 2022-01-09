using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Search_Algorithms
{
    class Node
    {
        public Node parent;
        public Vector2 position;
        public float weight;
        public float DistanceToEnd;
        public bool wall;

        public Node(Vector2 position, bool wall, float weight = 1)
        {
            parent = null;
            this.position = position;
            DistanceToEnd = -1f;
            this.weight = weight;
            this.wall = wall;

        }
    }
    class Search
    {
        private void printGrid(int[,] arr)
        {
            int rowLength = arr.GetLength(0);
            int colLength = arr.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        private Dictionary<Vector2, (Vector2, int)> graph = new Dictionary<Vector2, (Vector2, int)>();
        private Dictionary<Vector2, int> heuristic_values = new Dictionary<Vector2, int>();
        private List<Vector2> getNeighbours(Vector2 position, int size, int[,] arr)
        {
            List<Vector2> ListofVects = new List<Vector2>();
            int X = Convert.ToInt32(position.X);
            int Y = Convert.ToInt32(position.Y);
            if (X - 1 >= 0 && arr[X - 1, Y] != 1)
            {
                ListofVects.Add(new Vector2(X - 1, Y));
            }
            if (X + 1 <= size && arr[X + 1, Y] != 1)
            {
                ListofVects.Add(new Vector2(X + 1, Y));
            }
            if (Y - 1 >= 0 && arr[X, Y-1] != 1)
            {
                ListofVects.Add(new Vector2(X, Y - 1));
            }
            if (Y + 1 <= size && arr[X, Y+1] != 1)
            {
                ListofVects.Add(new Vector2(X, Y + 1));
            }
            return ListofVects;
        }
        public int[,] newAstar(int[,] arr)
        {
            Node start_node = new Node(new Vector2(0, 0), false);
            Node end_node = new Node(new Vector2(0, 0), false);
            List<Node> walls = new List<Node>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Vector2 c_Vecture = new Vector2(i, j);
                    heuristic_values.Add(c_Vecture, 1);
                    if (arr[i, j] == 2)
                    {
                        start_node.position = c_Vecture;
                        //arr[i, j] = 5;
                    }
                    else if (arr[i, j] == 3)
                    {
                        end_node.position = c_Vecture;
                        //arr[i, j] = 5;
                    }
                    else if (arr[i, j] == 1)
                    {
                        walls.Add(new Node(c_Vecture, true));
                    }


                }
            }

            return null;
        }
        public int[,] AStar(int[,] arr)
        {
            Vector2 start_node = new Vector2(0,0);
            Vector2 end_node = new Vector2(0, 0);


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Vector2 c_Vecture = new Vector2(i, j);
                    heuristic_values.Add(c_Vecture, 1);
                    if (arr[i, j] == 2)
                    {
                        start_node = c_Vecture;
                        //arr[i, j] = 5;
                    }
                    else if (arr[i, j] == 3)
                    {
                        end_node = c_Vecture;
                        //arr[i, j] = 5;
                    }
                    

                }
            }
            Dictionary<Vector2, int> poo = new Dictionary<Vector2, int>();
            Dictionary<Vector2, Vector2> par = new Dictionary<Vector2, Vector2>();
            List<Vector2> open_list = new List<Vector2>();
            List<Vector2> closed_list = new List<Vector2>();

            poo.Add(start_node, 0);
            open_list.Add(start_node);
            par.Add(start_node, start_node);
            

            while (open_list.Count > 0)
            {
                Vector2 n = new Vector2(-1,-1);
                Vector2 nullVector = new Vector2(-1, -1);

                foreach (Vector2 v in open_list)
                {
                    if (n == nullVector || poo[v] + heuristic_values[v] < poo[n] + heuristic_values[n])
                    {
                        n = v;
                    }
                }
                if (n == nullVector)
                {
                    Console.WriteLine("Path does not exist!");
                    return null;
                }
                if (n == end_node)
                {
                    List<Vector2> reconstruct_path = new List<Vector2> ();
                    while (par[n] != n)
                    {
                        n = par[n];
                        //reconstruct_path.Add(n);
                        if (n != par[n])
                        {
                            arr[Convert.ToInt32(n.X), Convert.ToInt32(n.Y)] = 5;
                        }
                    }/*
                    reconstruct_path.Remove(end_node);
                    reconstruct_path.Remove(start_node);*/
                    /*foreach (Vector2 vect in reconstruct_path)
                    {
                        int x = Convert.ToInt32(vect.X);
                        int y = Convert.ToInt32(vect.Y);
                        arr[x, y] = 5;
                    }*/
                    return arr;
                }

                foreach (Vector2 m in getNeighbours(n, arr.GetLength(0)-1,arr))
                { 
                    if(!open_list.Contains(m) && !closed_list.Contains(m))
                    {
                        open_list.Add(m);
                        par[m] = n;
                        poo[m] = poo[n];
                    }
                    else
                    {
                        if(poo[m] > poo[n])
                        {
                            poo[m] = poo[n];
                            par[m] = n;
                            if (closed_list.Contains(m))
                            {
                                closed_list.Remove(m);
                                open_list.Add(m);
                            }

                        }
                    }
                }
                open_list.Remove(n);
                closed_list.Add(n);
            }
            Console.WriteLine("Path does not Exist!");

            return null;
        }
    }
}