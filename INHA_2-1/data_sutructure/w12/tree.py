class TreeNode() :
	def __init__ (self) :
		self.left = None
		self.data = None
		self.right = None

def preorder(node):
    if node is None:
        return
    print(f"{node.data}->", end=" ")
    preorder(node.left)
    preorder(node.right)
		
def inorder(node):
    if node is None:
        return
    inorder(node.left)
    print(f"{node.data}->", end=" ")
    inorder(node.right)

def postorder(node):
    if node is None:
        return
    postorder(node.left)
    postorder(node.right)
    print(f"{node.data}->", end=" ")
	
#                 화사
#       솔라                문별
#   휘인   쯔위         선미
node1 = TreeNode()
node1.data = '화사'

node2 = TreeNode()
node2.data = '솔라'
node1.left = node2

node3 = TreeNode()
node3.data = '문별'
node1.right = node3

node4 = TreeNode()
node4.data = '휘인'
node2.left = node4

node5 = TreeNode()
node5.data = '쯔위'
node2.right = node5

node6 = TreeNode()
node6.data = '선미'
node3.left = node6

node7 = TreeNode()
node7.data = '다현'
node4.right = node7

node8 = TreeNode()
node8.data = '사나'
node6.right = node8

preorder(node1)
print("끝")