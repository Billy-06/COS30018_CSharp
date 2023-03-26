namespace COS30018.Algorithms;

/**
 * <summary>
 *  A class on the individual A* Search Algorithm Nodes with the 
 *  lowest f(n) value are expanded first. The f(n) value is the sum 
 *  of the g(n) and h(n) values. The g(n) value is the cost of the path 
 *  from the start node to the current node. The h(n) value is the estimated 
 *  cost of the cheapest path from the current node to the goal node. 
 *  The A star search algorithm is guaranteed to find the cheapest path from 
 *  the start node to the goal node.
 * </summary>
 * <param name="h(n)">
 *  The heuristic function is used to estimate the cost of the cheapest 
 *  path from the current node to the goal node.
 * </param>
 * <returns></returns>
 */
public class AStarSearchNode{
    /**
     * <summary>
     *  The parent node of the A* Search Algorithm tree.
     * </summary>
     * <value></value>
     */
    public AStarSearchNode? Parent { get; set; }
    /**
     * <summary>
     * The left node of the A* Search Algorithm tree.
     * </summary>
     * <value></value>
     */
    public AStarSearchNode? Left { get; set; }
    /**
     * <summary>
     * The right node of the A* Search Algorithm tree.
     * </summary>
     * <value></value>
     */
    public AStarSearchNode? Right { get; set; }
    /**
     * <summary>
     *  The g(n) value is the cost of the path from the start node
     *  to the current node.
     * </summary>
     * <value></value>
     */
    public int FunctionG { get; set; }
    /**
     * <summary>
     *  The h(n) value is the estimated cost of the cheapest path 
     *  from the current node to the goal node.
     * </summary>
     * <value></value>
     */
    public int FunctionH { get; set; }
    /**
     * <summary>
     *  The f(n) value is the sum of the g(n) and h(n) values.
     * </summary>
     * <value></value>
     */
    public int FunctionF { get; set; }

    /**
     * <summary>
     *  A default constructor of the A* Search Algorithm Node class.
     * </summary>
     * <typeparam name="summary"></typeparam>
     */
    public AStarSearchNode()
    {
        this.Parent = null;
        this.Left = null;
        this.Right = null;
        this.FunctionG = 0;
        this.FunctionH = 0;
        this.FunctionF = 0;
    }

    /**
     * <summary>
     *  A constructor of the A* Search Algorithm Node class that takes in all the parameters.
     * </summary>
     * <param name="x">
     *  The left node of the A* Search Algorithm tree.
     * </param>
     * <param name="y">
     *  The right node of the A* Search Algorithm tree.
     * </param>
     * <param name="g">
     *  The g(n) value is the cost of the path from the start node to the current node.
     * </param>
     * <param name="h">
     *  The h(n) value is the estimated cost of the cheapest path from the current node to the goal node.
     * </param>
     * <param name="f">
     *  The f(n) value is the sum of the g(n) and h(n) values.
     * </param>
     * <param name="parent">
     *  The parent node of the A* Search Algorithm tree.
     * </param>
     */
    public AStarSearchNode(AStarSearchNode x, AStarSearchNode y, int g, int h, int f, AStarSearchNode parent)
    {
        this.Left = x;
        this.Right = y;
        this.FunctionG = g;
        this.FunctionH = h;
        this.FunctionF = f;
        this.Parent = parent;
    }

}

/**
 * A* Search Algorithm
 * 
 * @author  Billy Micah COS30018
 * @version 1.0
 * 
 * A star search algorithm follows the same basic structure as the breadth first search algorithm.
 * The only difference is that the A star search algorithm uses a heuristic function to determine
 * the next node to be expanded. The heuristic function is used to estimate the cost of the cheapest
 * path from the current node to the goal node. The A star search algorithm is guaranteed to find
 * the cheapest path from the start node to the goal node.
 * 
 * f(n) = g(n) + h(n)
 * 
 * <summary>
 *     The tree representaton of the A* Search Algorithm which uses the AStarSearchNode class
 *     as indiviual nodes in the tree.
 * </summary>
 * <param name="h(n)">
 *  The heuristic function is used to estimate the cost of the cheapest path from the current node to the goal node.
 * </param>
 * <returns></returns>
 */
public class AStarSearchTree {
    /**
     * <summary>
     *  The root node of the A* Search Algorithm tree.
     * </summary>
     * <value></value>
     */
    public AStarSearchNode Root { get; set; }
    public AStarSearchTree(AStarSearchNode root)
    {
        this.Root = root;
    }

    // Create a function that will return the lowest f(n) value along with the node that has the lowest f(n) value.
    public AStarSearchNode GetLowestFValueNode(AStarSearchNode node)
    {
        AStarSearchNode lowestFValueNode = node;

        if (node.Left != null)
        {
            AStarSearchNode leftNode = GetLowestFValueNode(node.Left);
            if (leftNode.FunctionF < lowestFValueNode.FunctionF)
            {
                lowestFValueNode = leftNode;
            }
        }
        if (node.Right != null)
        {
            AStarSearchNode rightNode = GetLowestFValueNode(node.Right);
            if (rightNode.FunctionF < lowestFValueNode.FunctionF)
            {
                lowestFValueNode = rightNode;
            }
        }
        return lowestFValueNode;
    }

}
