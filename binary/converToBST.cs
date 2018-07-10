using System;

namespace binary
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
    public class converToBST
    {
        public static Node root;
        public static Node SortedArrayToBST(int[] arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node newNode = new Node(arr[mid]);
            newNode.left = SortedArrayToBST(arr, start, mid - 1);
            newNode.right = SortedArrayToBST(arr, mid + 1, end);
            return newNode;
        }

        static void Main(string[] args)
        {
            int[] arr = new[] { -10, -3, 0, 5, 9 };
            System.Console.WriteLine(SortedArrayToBST(arr, 0, arr.Length - 1));
            root = SortedArrayToBST(arr, 0, arr.Length - 1);
            // Inorder(root);
            Preorder(root);
        }

        public static void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                System.Console.WriteLine(Root.data);
                Inorder(Root.right);
            }
        }

        public static void Preorder(Node Root)
        {
            if (Root != null)
            {
                System.Console.WriteLine(Root.data + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }
    }
}