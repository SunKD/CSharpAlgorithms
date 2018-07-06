using System;

namespace binary
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value)
        {
            this.value = value;
        }
    }

    public class Tree
    {
        public TreeNode root;

        public void insert(int value)
        {
            TreeNode newNode = new TreeNode(value);
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                TreeNode runner = this.root;
                TreeNode parent;
                while (runner != null)
                {
                    parent = runner;
                    if (value < this.root.value)
                    {
                        runner = runner.left;
                        if (runner == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        runner = runner.right;
                        if (runner == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public TreeNode getRoot(Tree tree)
        {
            return tree.root;
        }
        public void Preorder(TreeNode Root)
        {
            if (Root != null)
            {
                System.Console.WriteLine(Root.value + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }
        public void Inorder(TreeNode Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                System.Console.WriteLine(Root.value);
                Inorder(Root.right);
            }
        }

        public void PostOrder(TreeNode Root)
        {
            if (Root != null)
            {
                PostOrder(Root.left);
                PostOrder(Root.right);
                System.Console.WriteLine(Root.value);
            }
        }

        public int Height(TreeNode Root){
            if(Root == null){
                return 0;
            }else{
                int lHeight = Height(Root.left);
                int rHeight = Height(Root.right);
                if(lHeight > rHeight){
                    return lHeight+1;
                }else{
                    return rHeight+1;
                }
            }
        }
    }
}