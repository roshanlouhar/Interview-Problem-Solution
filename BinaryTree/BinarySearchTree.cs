using System;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public TreeNode root;

        public void PostOrderTraversal()
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
            Console.WriteLine();
        }
        public void PreOrderTraversal()
        {
            if(root !=null)
            {
                root.PreOrderTraversal();
            }
            Console.WriteLine();
        }
        public void InOrderTraversal()
        {
            if(root != null)
            {
                root.InorderTraversal();
            }
            Console.WriteLine();
        }
        public int largest()
        {
            if (root != null)
            {
                return root.largest();
            }
            return 0;
        }
        public int smallest()
        {
            if(root!= null)
            {
                return root.smallest();
            }
            return 0;
        }
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
            }
            else
            {
                root.insert(data);
            }
        }
        public TreeNode Find(int data)
        {
            if (root != null)
                return root.find(data);

            return null;
        }
        public void Delete(int data)
        {
            TreeNode parent = this.root;
            TreeNode current = this.root;
            bool isleft = false;

            if (root == null)
                return;
            while (current != null && current.GetData() != data)
            {
                parent = current;
                if(current.GetData() < data)
                {
                    current = current.GetLeft();
                    isleft = true;
                }
                else
                {
                    current = current.GetRight();
                    isleft = false;
                }
            }
            if (current == null)
                return;

            if(current.GetRight() ==null && current.GetLeft() == null)
            {
                if(root== current)
                {
                    root = null;
                }
                else
                {
                    if(isleft ==true)
                    {
                        current.SetLeft(null);
                    }
                    else
                    {
                        current.SetRight(null);
                    }
                }
            }  
            else if(current.GetLeft() == null)
            {
                if (root == current)
                {
                    root = current.GetRight();
                }
                else if (isleft)
                {
                    parent.SetLeft(current.GetRight());
                }
                else
                {
                    parent.SetRight(current.GetRight());
                }
            }
            else if (current.GetRight() == null)
            {
                if (root == current)
                {
                    root = current.GetLeft();
                }
                else if (isleft)
                {
                    parent.SetLeft(current.GetLeft());
                }
                else
                {
                    parent.SetRight(current.GetLeft());
                }
            }
            else
            {
                TreeNode successor = getSuccessor(current);
                if (current == root)
                    root = successor;
                else if (isleft)
                {
                    parent.SetLeft(successor);
                }
                else
                {
                    parent.SetRight(successor);
                }
                successor.SetLeft(current.GetLeft());
            }
        }
        private TreeNode getSuccessor(TreeNode node)
        {
            TreeNode parentOfSuccessor = node;
            TreeNode successor = node;
            TreeNode current = node.GetRight();
            while (current != null)
            {
                parentOfSuccessor = successor;
                successor = current;
                current = current.GetLeft();
            }
            if (successor != node.GetRight())
            {
                parentOfSuccessor.SetLeft(successor.GetRight());
                successor.SetRight(node.GetRight());
            }
            return successor;
        }

    }
}
