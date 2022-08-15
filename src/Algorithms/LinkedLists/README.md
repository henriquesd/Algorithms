# LinkedLists

## Linked List
A Linked List is a container where nodes of data are linked together into a list.

A container where data is stored in nodes consisting of a single data item and a reference to the next node.

A LinkedList is a linear data structure which consists of a group of nodes in a sequence. The elements in a linked list are linked with each other using pointers.

LinkedList consists of nodes where each node contains a data field and a reference (link) to the next node in the list.

A Linked List is similar to a chain, where each link in the chain contains a single piece of data, and like a chain, each link is connected to the ones immediately adjacent to it. This means that you can get from any link in the chain to any other link by starting at the beginning and then moving your way through all the links to the end of the list.

## Singly Linked List
A linked list that provides forward iteration from the start to the end of the list.

I.e., Next, which points to the next node in the sequence of nodes. The next pointer of the last node will point to null.

This is a list where we can start at the first node and follow the chain of nodes iterating over each, until we get to the end.

## Doubly Linked List
A linked list that provides forward iteration from the start to the end of the list, and reverse iteration, from end to start.
In a doubly linked list, each node contains two links - the first link points to the previous node and the next link points to the next node in the sequence. The prev pointer of the first node and the next pointer of the last node will point to null.

The Doubly Linked List builds on the Singly Linked List by adding reverse iteration. It allows traversing not just from one node to the next in forwarding order but also to the previous node.