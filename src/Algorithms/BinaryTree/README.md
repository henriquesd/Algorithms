# BinaryTree

## Binary Tree:
It's a tree structure whose nodes have, at most, two children.
  
Binary trees start with the root node (with no parent), and because it's a binary tree, it can have, at most, two children (left and right children) - each of these children have a single parent, and each of these children can have, at most, two children (can be one or two children).

## Binary Tree Node:
It's a node which contains a single data item and pointers for the left and right child.

## Binary Search Tree:
A binary tree where nodes with lessor values are placed to the left of the root, and nodes with equal or greater values are placed to the right.

## Tree Traversals

### Pre-Order
We perform the action on the current node before we visit either child.
The node is visited before it's children.

### In-Order
The left child is visited, then we perform the action, then we visit the right child.
The left child is visited before the node, then the right child.

### Post-Order
Both the left and right children are visited before we process the current node.
The left and right children are visited before the node.