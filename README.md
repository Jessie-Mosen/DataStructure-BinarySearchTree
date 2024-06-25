# DataStructure-BinarySearchTree
Binary Search Tree (BST) Implementation in C#
This project provides an implementation of a Binary Search Tree (BST) in C#. The program can read a list of words from a text file, insert them into the BST, and perform various operations such as searching, deleting, and traversing the tree.

Project Structure
The project contains the following files and namespaces:

Node.cs: Defines the Node class which represents a node in the BST.
Program.cs: Contains the Main method and the main application logic.
BSTree.cs: Defines the BSTree class which implements the BST operations.
Node Class
The Node class represents a single node in the BST and contains the following properties:

Word: The word stored in the node.
Left: Reference to the left child node.
Right: Reference to the right child node.
WordLength: The length of the word.
Position: The position of the word in the file (optional, currently set to -1).
Constructors
Node(): Initializes a node with default values.
Node(string word): Initializes a node with the specified word.
Methods
ToString(): Returns the word stored in the node as a string.
BSTree Class
The BSTree class implements the binary search tree and contains the following properties and methods:

Properties
Root: The root node of the BST.
Methods
Add(string word): Adds a word to the BST.
Find(string word): Searches for a word in the BST and returns a message indicating if the word was found.
Remove(string word): Removes a word from the BST and returns a message indicating if the word was removed.
PreOrder(), InOrder(), PostOrder(): Returns a string representation of the BST in pre-order, in-order, and post-order traversal, respectively.
TreeDepth(): Returns the depth of the BST.
Program Class
The Program class contains the Main method and the main application logic. It provides a user interface to interact with the BST.

Main Method
Prompts the user to select the type of file (ordered or random) and the file size.
Reads the selected file and inserts the words into the BST.
Provides options to perform various operations on the BST such as printing, searching, deleting, and inserting nodes.
Measures and displays the time taken for each operation.
How to Run
Open the project in your preferred C# IDE (e.g., Visual Studio).
Ensure the text files (e.g., 1000-words.txt, 5000-words.txt, etc.) are located in the appropriate directories (../ordered/ and ../random/).
Run the application.
Follow the on-screen prompts to select the file type and size, and perform various operations on the BST.

Future Enhancements
Implement balancing algorithms to ensure the BST remains balanced.
Improve the user interface for better usability.
Add functionality to save and load the BST state.
Conclusion
This project provides a basic implementation of a Binary Search Tree in C# with functionalities to read from a file, insert, search, delete, and traverse nodes. It serves as a foundation for further enhancements and learning about BSTs in C#.
