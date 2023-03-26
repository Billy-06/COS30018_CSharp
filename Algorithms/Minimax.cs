using System;
using System.Collections.Generic;

namespace COS30018.Algorithms;

/**
 * <summary>
 *  A class on the individual Minimax Algorithm Nodes with the 
 *  lowest f(n) value are expanded first. The f(n) value is the sum 
 *  of the g(n) and h(n) values. The g(n) value is the cost of the path 
 *  from the start node to the current node. The h(n) value is the estimated 
 *  cost of the cheapest path from the current node to the goal node. 
 *  <br/>
 *  The Minimax algorithm is guaranteed to find the cheapest path from 
 *  the start node to the goal node.
 * </summary>
 * <param name="h(n)">
 *  The heuristic function is used to estimate the cost of the cheapest 
 *  path from the current node to the goal node.
 * </param>
 * <returns></returns>
 */
public class Minimax
{

}