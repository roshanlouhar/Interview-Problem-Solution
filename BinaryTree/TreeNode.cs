using System;

namespace BinaryTree
{
    public class TreeNode
    {
        int data;
        TreeNode left;
        TreeNode right;

        public void PostOrderTraversal()
        {
            if (this.left != null)
                this.left.PostOrderTraversal();
            if (this.right != null)
                this.right.PostOrderTraversal();
            Console.WriteLine(this.GetData());                
        }
        public void PreOrderTraversal()
        {
            Console.WriteLine(this.GetData());
            if (this.left != null)
                this.left.PreOrderTraversal();
            if (this.right != null)
                this.right.PreOrderTraversal();
        }
        public void InorderTraversal()
        {
            if (this.left != null)
                this.left.InorderTraversal();
            Console.WriteLine(this.data + "\t");
            if (this.right != null)
                this.right.InorderTraversal();
        }
        public int smallest()
        {
            if (this.left == null)
            {
                return this.left.GetData();
            }
            return this.left.smallest();
        }
        public int largest()
        {
            if (this.right == null)
            {
                return this.right.GetData();
            }
            return this.right.largest();
        }
        public TreeNode(int value)
        {
            this.data = value;
            left = right = null;
        }
        public int GetData()
        {
            return this.data;
        }
        public TreeNode GetLeft()
        {
            return this.left;
        }
        public TreeNode GetRight()
        {
            return this.right;
        }
        public void SetLeft(TreeNode left)
        {
            this.left = left;
        }
        public void SetRight(TreeNode right)
        {
            this.right = right;
        }
        public TreeNode find(int data)
        {
            if (this.data == data)
            {
                return this;
            }
            if (this.data > data && this.left != null)
            {
                return this.left.find(data);
            }
            if (this.right != null)
            {
                return this.right.find(data);
            }
            return null;
        }
        public void insert(int data)
        {
            if (data < this.data)
            {
                if (this.left == null)
                {
                    this.left = new TreeNode(data);
                }
                else
                {
                    this.left.insert(data);
                }
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new TreeNode(data);
                }
                else
                {
                    this.right.insert(data);
                }
            }
        }
    }
}
